using System.ComponentModel.DataAnnotations;

namespace AutoPartsStore.API.Models
{
    public class Review
    {
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public int? UserId { get; set; }
        public User? User { get; set; }

        [Required(ErrorMessage = "İsim gereklidir.")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "İsim 2-200 karakter arasında olmalıdır.")]
        public string CustomerName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email adresi gereklidir.")]
        [EmailAddress(ErrorMessage = "Geçerli bir email adresi giriniz.")]
        [StringLength(200, ErrorMessage = "Email adresi en fazla 200 karakter olabilir.")]
        public string CustomerEmail { get; set; } = string.Empty;

        [Required(ErrorMessage = "Puan gereklidir.")]
        [Range(1, 5, ErrorMessage = "Puan 1 ile 5 arasında olmalıdır.")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Yorum gereklidir.")]
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "Yorum 10-1000 karakter arasında olmalıdır.")]
        public string Comment { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public bool IsApproved { get; set; } = false;
    }
}
