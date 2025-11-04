using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using AutoPartsStore.API.Data;
using AutoPartsStore.API.Models;
using AutoPartsStore.API.Services;
using System.Security.Claims;

namespace AutoPartsStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class OrdersController : ControllerBase
    {
        private readonly AutoPartsDbContext _context;
        private readonly EmailService _emailService;

        public OrdersController(AutoPartsDbContext context, EmailService emailService)
        {
            _context = context;
            _emailService = emailService;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var roleClaim = User.FindFirst(ClaimTypes.Role)?.Value;

            // Adminler tüm siparişleri görebilir
            if (roleClaim == "Admin")
            {
                return await _context.Orders
                    .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.Product)
                    .ToListAsync();
            }

            // Normal kullanıcılar sadece kendi siparişlerini görebilir
            if (!int.TryParse(userIdClaim, out int userId))
            {
                return Unauthorized();
            }

            return await _context.Orders
                .Where(o => o.UserId == userId)
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
                .ToListAsync();
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var roleClaim = User.FindFirst(ClaimTypes.Role)?.Value;

            var order = await _context.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
                .FirstOrDefaultAsync(o => o.Id == id);

            if (order == null)
            {
                return NotFound();
            }

            // Adminler tüm siparişleri görebilir, normal kullanıcılar sadece kendi siparişlerini
            if (roleClaim != "Admin")
            {
                if (!int.TryParse(userIdClaim, out int userId) || order.UserId != userId)
                {
                    return Forbid();
                }
            }

            return order;
        }

        // GET: api/Orders/number/ORD-123456
        [HttpGet("number/{orderNumber}")]
        [AllowAnonymous]  // Sipariş takibi için anonymous erişime izin ver
        public async Task<ActionResult<Order>> GetOrderByNumber(string orderNumber)
        {
            var order = await _context.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
                .FirstOrDefaultAsync(o => o.OrderNumber == orderNumber);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        // POST: api/Orders
        [HttpPost]
        [AllowAnonymous]  // Misafir kullanıcılar da sipariş verebilmeli
        public async Task<ActionResult<Order>> PostOrder(CreateOrderDto orderDto)
        {
            var order = new Order
            {
                OrderNumber = $"ORD-{DateTime.UtcNow.Ticks}",
                CustomerName = orderDto.CustomerName,
                CustomerEmail = orderDto.CustomerEmail,
                CustomerPhone = orderDto.CustomerPhone,
                ShippingAddress = orderDto.ShippingAddress,
                City = orderDto.City,
                PostalCode = orderDto.PostalCode,
                Status = "Pending",
                OrderDate = DateTime.UtcNow
            };

            // Eğer kullanıcı giriş yapmışsa UserId'yi set et
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (int.TryParse(userIdClaim, out int userId))
            {
                order.UserId = userId;
            }

            decimal totalAmount = 0;

            foreach (var item in orderDto.Items)
            {
                var product = await _context.Products.FindAsync(item.ProductId);
                if (product == null)
                {
                    return BadRequest($"Product with ID {item.ProductId} not found.");
                }

                if (product.Stock < item.Quantity)
                {
                    return BadRequest($"Insufficient stock for product {product.Name}.");
                }

                var orderItem = new OrderItem
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    Price = product.Price
                };

                order.OrderItems.Add(orderItem);
                totalAmount += product.Price * item.Quantity;

                // Update stock
                product.Stock -= item.Quantity;
            }

            order.TotalAmount = totalAmount;

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            // Siparişi OrderItems ile birlikte yükle (email için gerekli)
            var createdOrder = await _context.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
                .FirstOrDefaultAsync(o => o.Id == order.Id);

            if (createdOrder != null)
            {
                // Sipariş onay emaili gönder
                await _emailService.SendOrderConfirmationEmail(createdOrder);

                // Stok kontrolü yap ve gerekirse uyarı gönder
                foreach (var item in createdOrder.OrderItems)
                {
                    if (item.Product != null && item.Product.Stock <= 10)
                    {
                        await _emailService.SendLowStockAlert(item.Product);
                    }
                }
            }

            return CreatedAtAction(nameof(GetOrder), new { id = order.Id }, order);
        }
    }

    // DTOs
    public class CreateOrderDto
    {
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerEmail { get; set; } = string.Empty;
        public string CustomerPhone { get; set; } = string.Empty;
        public string ShippingAddress { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public List<OrderItemDto> Items { get; set; } = new List<OrderItemDto>();
    }

    public class OrderItemDto
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
