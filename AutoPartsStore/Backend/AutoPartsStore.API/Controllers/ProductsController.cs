using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoPartsStore.API.Data;
using AutoPartsStore.API.Models;

namespace AutoPartsStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AutoPartsDbContext _context;

        public ProductsController(AutoPartsDbContext context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts(
            [FromQuery] int? categoryId = null,
            [FromQuery] int? brandId = null,
            [FromQuery] string? search = null,
            [FromQuery] bool? featured = null,
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 12)
        {
            var query = _context.Products
                .Include(p => p.Category)
                .Include(p => p.Brand)
                .Include(p => p.PartBrand)
                .AsQueryable();

            if (categoryId.HasValue)
            {
                query = query.Where(p => p.CategoryId == categoryId.Value);
            }

            if (brandId.HasValue)
            {
                query = query.Where(p => p.BrandId == brandId.Value);
            }

            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(p =>
                    p.Name.Contains(search) ||
                    p.Brand.Name.Contains(search) ||
                    p.PartNumber.Contains(search));
            }

            if (featured.HasValue && featured.Value)
            {
                query = query.Where(p => p.IsFeatured);
            }

            var totalItems = await query.CountAsync();
            var products = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            Response.Headers.Append("X-Total-Count", totalItems.ToString());
            Response.Headers.Append("X-Page", page.ToString());
            Response.Headers.Append("X-Page-Size", pageSize.ToString());

            return products;
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Brand)
                .Include(p => p.PartBrand)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        // GET: api/Products/featured
        [HttpGet("featured")]
        public async Task<ActionResult<IEnumerable<Product>>> GetFeaturedProducts()
        {
            return await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Brand)
                .Include(p => p.PartBrand)
                .Where(p => p.IsFeatured)
                .Take(8)
                .ToListAsync();
        }

        // GET: api/Products/search
        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<Product>>> SearchProducts([FromQuery] string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return BadRequest("Search query cannot be empty.");
            }

            var products = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Brand)
                .Include(p => p.PartBrand)
                .Where(p =>
                    p.Name.Contains(query) ||
                    p.Brand.Name.Contains(query) ||
                    p.PartBrand.Name.Contains(query) ||
                    p.PartNumber.Contains(query) ||
                    p.Description.Contains(query))
                .Take(20)
                .ToListAsync();

            return products;
        }
    }
}
