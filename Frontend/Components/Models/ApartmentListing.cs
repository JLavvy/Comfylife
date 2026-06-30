namespace Comfylife.Frontend.Models;

public class ApartmentListing
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Tagline { get; set; } = "";
    public string Image { get; set; } = "";
    public string Location { get; set; } = "";
    public string Area { get; set; } = "";
    public string Description { get; set; } = "";
    public string LongDescription { get; set; } = "";
    public int Bedrooms { get; set; }
    public string Beds { get; set; } = "";
    public int Bathrooms { get; set; }
    public string Size { get; set; } = "";
    public string Floor { get; set; } = "";
    public int MaxGuests { get; set; }
    public int NightlyRate { get; set; }
    public int MonthlyRate { get; set; }
    public List<string> Amenities { get; set; } = new();
    public List<string> Features { get; set; } = new();
    public List<string> Images { get; set; } = new();
    public bool IsActive { get; set; } = true;
}