using System.ComponentModel.DataAnnotations;

namespace AutoPartsStore.API.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Kategori adı gereklidir.")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Kategori adı 2-200 karakter arasında olmalıdır.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Slug gereklidir.")]
        [StringLength(200, ErrorMessage = "Slug en fazla 200 karakter olabilir.")]
        public string Slug { get; set; } = string.Empty;

        [StringLength(1000, ErrorMessage = "Açıklama en fazla 1000 karakter olabilir.")]
        public string Description { get; set; } = string.Empty;

        [StringLength(500, ErrorMessage = "Resim URL'si en fazla 500 karakter olabilir.")]
        public string ImageUrl { get; set; } = string.Empty;

        public int? ParentCategoryId { get; set; }
        public Category? ParentCategory { get; set; }
        public ICollection<Category> SubCategories { get; set; } = new List<Category>();
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
