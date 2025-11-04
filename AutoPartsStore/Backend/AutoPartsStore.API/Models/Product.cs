using System.ComponentModel.DataAnnotations;

namespace AutoPartsStore.API.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ürün adı gereklidir.")]
        [StringLength(500, MinimumLength = 2, ErrorMessage = "Ürün adı 2-500 karakter arasında olmalıdır.")]
        public string Name { get; set; } = string.Empty;

        [StringLength(2000, ErrorMessage = "Açıklama en fazla 2000 karakter olabilir.")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Parça numarası gereklidir.")]
        [StringLength(100, ErrorMessage = "Parça numarası en fazla 100 karakter olabilir.")]
        public string PartNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Fiyat gereklidir.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Fiyat 0'dan büyük olmalıdır.")]
        public decimal Price { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Eski fiyat 0'dan büyük olmalıdır.")]
        public decimal? OldPrice { get; set; }

        [Required(ErrorMessage = "Stok miktarı gereklidir.")]
        [Range(0, int.MaxValue, ErrorMessage = "Stok miktarı 0 veya daha büyük olmalıdır.")]
        public int Stock { get; set; }

        [StringLength(500, ErrorMessage = "Resim URL'si en fazla 500 karakter olabilir.")]
        public string ImageUrl { get; set; } = string.Empty;
        public List<string> AdditionalImages { get; set; } = new List<string>();
        public double Rating { get; set; }
        public int ReviewCount { get; set; }
        public int? DiscountPercentage { get; set; }
        public string? BadgeText { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsNew { get; set; }

        // Foreign Keys
        public int CategoryId { get; set; }
        public int BrandId { get; set; } // Vehicle Brand (Araç Markası)
        public int PartBrandId { get; set; } // Part Brand (Parça Markası)

        // Navigation properties
        public Category Category { get; set; } = null!;
        public Brand Brand { get; set; } = null!; // Vehicle Brand
        public PartBrand PartBrand { get; set; } = null!; // Part Brand

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
