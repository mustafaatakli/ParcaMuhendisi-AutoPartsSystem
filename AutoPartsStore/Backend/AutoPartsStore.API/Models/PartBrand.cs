using System.ComponentModel.DataAnnotations;

namespace AutoPartsStore.API.Models
{
    public class PartBrand
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Parça markası adı gereklidir.")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "Parça markası adı 1-200 karakter arasında olmalıdır.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Slug gereklidir.")]
        [StringLength(200, ErrorMessage = "Slug en fazla 200 karakter olabilir.")]
        public string Slug { get; set; } = string.Empty;

        [StringLength(500, ErrorMessage = "Logo URL'si en fazla 500 karakter olabilir.")]
        public string? LogoUrl { get; set; }

        // Navigation property
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
