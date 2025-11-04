using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoPartsStore.API.Data;
using AutoPartsStore.API.Models;

namespace AutoPartsStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartBrandsController : ControllerBase
    {
        private readonly AutoPartsDbContext _context;

        public PartBrandsController(AutoPartsDbContext context)
        {
            _context = context;
        }

        // GET: api/PartBrands
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PartBrand>>> GetPartBrands()
        {
            return await _context.PartBrands.OrderBy(b => b.Name).ToListAsync();
        }

        // GET: api/PartBrands/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PartBrand>> GetPartBrand(int id)
        {
            var partBrand = await _context.PartBrands.FindAsync(id);

            if (partBrand == null)
            {
                return NotFound();
            }

            return partBrand;
        }

        // GET: api/PartBrands/slug/bosch
        [HttpGet("slug/{slug}")]
        public async Task<ActionResult<PartBrand>> GetPartBrandBySlug(string slug)
        {
            var partBrand = await _context.PartBrands
                .FirstOrDefaultAsync(b => b.Slug == slug);

            if (partBrand == null)
            {
                return NotFound();
            }

            return partBrand;
        }
    }
}
