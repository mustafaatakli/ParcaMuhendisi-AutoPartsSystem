using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoPartsStore.API.Data;
using AutoPartsStore.API.Models;

namespace AutoPartsStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class AdminController : ControllerBase
    {
        private readonly AutoPartsDbContext _context;

        public AdminController(AutoPartsDbContext context)
        {
            _context = context;
        }

        // GET: api/Admin/products
        [HttpGet("products")]
        public async Task<ActionResult<IEnumerable<object>>> GetAllProducts()
        {
            var products = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Brand)
                .Include(p => p.PartBrand)
                .ToListAsync();

            return products.Select(p => new
            {
                p.Id,
                p.Name,
                p.Description,
                Brand = new { p.Brand.Id, p.Brand.Name, p.Brand.Slug },
                BrandId = p.BrandId,
                PartBrand = new { p.PartBrand.Id, p.PartBrand.Name, p.PartBrand.Slug },
                PartBrandId = p.PartBrandId,
                p.PartNumber,
                p.Price,
                p.OldPrice,
                p.Stock,
                p.ImageUrl,
                p.Rating,
                p.ReviewCount,
                p.DiscountPercentage,
                p.BadgeText,
                p.IsFeatured,
                p.IsNew,
                Category = new { p.Category.Id, p.Category.Name, p.Category.Slug },
                p.CategoryId,
                p.CreatedAt,
                p.UpdatedAt
            }).ToList();
        }

        // POST: api/Admin/products
        [HttpPost("products")]
        public async Task<ActionResult<Product>> CreateProduct(ProductCreateDto dto)
        {
            var product = new Product
            {
                Name = dto.Name,
                Description = dto.Description,
                BrandId = dto.BrandId,
                PartBrandId = dto.PartBrandId,
                PartNumber = dto.PartNumber,
                Price = dto.Price,
                OldPrice = dto.OldPrice,
                Stock = dto.Stock,
                ImageUrl = dto.ImageUrl ?? "/images/products/default.jpg",
                Rating = 0,
                ReviewCount = 0,
                DiscountPercentage = dto.DiscountPercentage,
                BadgeText = dto.BadgeText,
                IsFeatured = dto.IsFeatured,
                IsNew = dto.IsNew,
                CategoryId = dto.CategoryId,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAllProducts), new { id = product.Id }, product);
        }

        // PUT: api/Admin/products/5
        [HttpPut("products/{id}")]
        public async Task<IActionResult> UpdateProduct(int id, ProductUpdateDto dto)
        {
            var product = await _context.Products
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            // Validate foreign keys
            var categoryExists = await _context.Categories.AnyAsync(c => c.Id == dto.CategoryId);
            if (!categoryExists)
            {
                return BadRequest(new { error = $"Category with ID {dto.CategoryId} does not exist." });
            }

            var brandExists = await _context.Brands.AnyAsync(b => b.Id == dto.BrandId);
            if (!brandExists)
            {
                return BadRequest(new { error = $"Brand with ID {dto.BrandId} does not exist." });
            }

            var partBrandExists = await _context.PartBrands.AnyAsync(pb => pb.Id == dto.PartBrandId);
            if (!partBrandExists)
            {
                return BadRequest(new { error = $"PartBrand with ID {dto.PartBrandId} does not exist." });
            }

            // Update product
            product.Name = dto.Name;
            product.Description = dto.Description;
            product.BrandId = dto.BrandId;
            product.PartBrandId = dto.PartBrandId;
            product.PartNumber = dto.PartNumber;
            product.Price = dto.Price;
            product.OldPrice = dto.OldPrice;
            product.Stock = dto.Stock;
            product.ImageUrl = dto.ImageUrl ?? product.ImageUrl;
            product.DiscountPercentage = dto.DiscountPercentage;
            product.BadgeText = dto.BadgeText;
            product.IsFeatured = dto.IsFeatured;
            product.IsNew = dto.IsNew;
            product.CategoryId = dto.CategoryId;
            product.UpdatedAt = DateTime.UtcNow;

            _context.Products.Update(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Admin/products/5
        [HttpDelete("products/{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // GET: api/Admin/orders
        [HttpGet("orders")]
        public async Task<ActionResult<IEnumerable<Order>>> GetAllOrders()
        {
            return await _context.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
                .OrderByDescending(o => o.OrderDate)
                .ToListAsync();
        }

        // PUT: api/Admin/orders/5/status
        [HttpPut("orders/{id}/status")]
        public async Task<IActionResult> UpdateOrderStatus(int id, UpdateOrderStatusDto dto)
        {
            var order = await _context.Orders.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            order.Status = dto.Status;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // GET: api/Admin/users
        [HttpGet("users")]
        public async Task<ActionResult<IEnumerable<User>>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        }

        // GET: api/Admin/stats
        [HttpGet("stats")]
        public async Task<ActionResult<DashboardStats>> GetStats()
        {
            var totalProducts = await _context.Products.CountAsync();
            var totalOrders = await _context.Orders.CountAsync();
            var totalUsers = await _context.Users.CountAsync();
            var totalRevenue = await _context.Orders.SumAsync(o => o.TotalAmount);
            var pendingOrders = await _context.Orders.CountAsync(o => o.Status == "Pending");

            return Ok(new DashboardStats
            {
                TotalProducts = totalProducts,
                TotalOrders = totalOrders,
                TotalUsers = totalUsers,
                TotalRevenue = totalRevenue,
                PendingOrders = pendingOrders
            });
        }
    }

    // DTOs
    public class ProductCreateDto
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int BrandId { get; set; }
        public int PartBrandId { get; set; }
        public string PartNumber { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal? OldPrice { get; set; }
        public int Stock { get; set; }
        public string? ImageUrl { get; set; }
        public int? DiscountPercentage { get; set; }
        public string? BadgeText { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsNew { get; set; }
        public int CategoryId { get; set; }
    }

    public class ProductUpdateDto : ProductCreateDto
    {
    }

    public class UpdateOrderStatusDto
    {
        public string Status { get; set; } = string.Empty;
    }

    public class DashboardStats
    {
        public int TotalProducts { get; set; }
        public int TotalOrders { get; set; }
        public int TotalUsers { get; set; }
        public decimal TotalRevenue { get; set; }
        public int PendingOrders { get; set; }
    }
}
