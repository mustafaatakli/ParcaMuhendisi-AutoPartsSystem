using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoPartsStore.API.Data;
using AutoPartsStore.API.Models;

namespace AutoPartsStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly AutoPartsDbContext _context;

        public BrandsController(AutoPartsDbContext context)
        {
            _context = context;
        }

        // GET: api/Brands
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Brand>>> GetBrands()
        {
            return await _context.Brands.OrderBy(b => b.Name).ToListAsync();
        }

        // GET: api/Brands/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Brand>> GetBrand(int id)
        {
            var brand = await _context.Brands.FindAsync(id);

            if (brand == null)
            {
                return NotFound();
            }

            return brand;
        }

        // GET: api/Brands/slug/bosch
        [HttpGet("slug/{slug}")]
        public async Task<ActionResult<Brand>> GetBrandBySlug(string slug)
        {
            var brand = await _context.Brands
                .FirstOrDefaultAsync(b => b.Slug == slug);

            if (brand == null)
            {
                return NotFound();
            }

            return brand;
        }
    }
}
