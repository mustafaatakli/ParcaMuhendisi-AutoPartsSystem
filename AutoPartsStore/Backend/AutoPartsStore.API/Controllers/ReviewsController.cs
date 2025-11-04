using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoPartsStore.API.Data;
using AutoPartsStore.API.Models;
using System.Security.Claims;

namespace AutoPartsStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly AutoPartsDbContext _context;

        public ReviewsController(AutoPartsDbContext context)
        {
            _context = context;
        }

        // GET: api/Reviews/product/5
        [HttpGet("product/{productId}")]
        public async Task<ActionResult<IEnumerable<Review>>> GetProductReviews(int productId)
        {
            // Sadece onaylanmış yorumları göster
            var reviews = await _context.Reviews
                .Include(r => r.User)
                .Where(r => r.ProductId == productId && r.IsApproved)
                .OrderByDescending(r => r.CreatedAt)
                .ToListAsync();

            return Ok(reviews);
        }

        // POST: api/Reviews
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<Review>> CreateReview(CreateReviewDto dto)
        {
            // Ürün var mı kontrol et
            var product = await _context.Products.FindAsync(dto.ProductId);
            if (product == null)
            {
                return NotFound("Ürün bulunamadı.");
            }

            var review = new Review
            {
                ProductId = dto.ProductId,
                CustomerName = dto.CustomerName,
                CustomerEmail = dto.CustomerEmail,
                Rating = dto.Rating,
                Comment = dto.Comment,
                CreatedAt = DateTime.UtcNow,
                IsApproved = false  // Admin onayı gerekli
            };

            // Eğer kullanıcı giriş yapmışsa UserId'yi set et
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (int.TryParse(userIdClaim, out int userId))
            {
                review.UserId = userId;
            }

            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();

            // Ürünün rating'ini güncelle
            await UpdateProductRating(dto.ProductId);

            return CreatedAtAction(nameof(GetProductReviews), new { productId = review.ProductId }, review);
        }

        // PUT: api/Reviews/5/approve (Admin only)
        [HttpPut("{id}/approve")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ApproveReview(int id)
        {
            var review = await _context.Reviews.FindAsync(id);
            if (review == null)
            {
                return NotFound();
            }

            review.IsApproved = true;
            await _context.SaveChangesAsync();

            // Ürünün rating'ini güncelle
            await UpdateProductRating(review.ProductId);

            return NoContent();
        }

        // DELETE: api/Reviews/5 (Admin only)
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteReview(int id)
        {
            var review = await _context.Reviews.FindAsync(id);
            if (review == null)
            {
                return NotFound();
            }

            var productId = review.ProductId;
            _context.Reviews.Remove(review);
            await _context.SaveChangesAsync();

            // Ürünün rating'ini güncelle
            await UpdateProductRating(productId);

            return NoContent();
        }

        // GET: api/Reviews/pending (Admin only)
        [HttpGet("pending")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<IEnumerable<Review>>> GetPendingReviews()
        {
            var reviews = await _context.Reviews
                .Include(r => r.Product)
                .Include(r => r.User)
                .Where(r => !r.IsApproved)
                .OrderByDescending(r => r.CreatedAt)
                .ToListAsync();

            return Ok(reviews);
        }

        private async Task UpdateProductRating(int productId)
        {
            var approvedReviews = await _context.Reviews
                .Where(r => r.ProductId == productId && r.IsApproved)
                .ToListAsync();

            if (approvedReviews.Any())
            {
                var product = await _context.Products.FindAsync(productId);
                if (product != null)
                {
                    product.Rating = approvedReviews.Average(r => r.Rating);
                    product.ReviewCount = approvedReviews.Count;
                    await _context.SaveChangesAsync();
                }
            }
        }
    }

    // DTOs
    public class CreateReviewDto
    {
        public int ProductId { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerEmail { get; set; } = string.Empty;
        public int Rating { get; set; }  // 1-5
        public string Comment { get; set; } = string.Empty;
    }
}
