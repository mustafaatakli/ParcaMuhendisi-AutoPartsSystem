using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoPartsStore.API.Data;
using AutoPartsStore.API.Models;

namespace AutoPartsStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly AutoPartsDbContext _context;

        public CategoriesController(AutoPartsDbContext context)
        {
            _context = context;
        }

        // GET: api/Categories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            return await _context.Categories
                .Include(c => c.SubCategories)
                .Where(c => c.ParentCategoryId == null)
                .ToListAsync();
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategory(int id)
        {
            var category = await _context.Categories
                .Include(c => c.SubCategories)
                .Include(c => c.Products)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            return category;
        }

        // GET: api/Categories/slug/motor-parcalari
        [HttpGet("slug/{slug}")]
        public async Task<ActionResult<Category>> GetCategoryBySlug(string slug)
        {
            var category = await _context.Categories
                .Include(c => c.SubCategories)
                .Include(c => c.Products)
                .FirstOrDefaultAsync(c => c.Slug == slug);

            if (category == null)
            {
                return NotFound();
            }

            return category;
        }
    }
}
