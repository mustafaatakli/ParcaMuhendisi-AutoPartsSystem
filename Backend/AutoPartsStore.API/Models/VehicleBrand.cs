namespace AutoPartsStore.API.Models;

public class VehicleBrand
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Slug { get; set; } = string.Empty;
    public string? LogoUrl { get; set; }

    // Navigation properties
    public ICollection<Product> Products { get; set; } = new List<Product>();
}

