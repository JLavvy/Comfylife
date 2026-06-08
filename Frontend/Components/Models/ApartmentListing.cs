namespace Comfylife.Frontend.Models;

public record ApartmentListing(
    int Id,
    string Name,
    string Tagline,
    string Image,
    string Location,
    string Area,
    string Description,
    string LongDescription,
    int Bedrooms,
    string Beds,
    int Bathrooms,
    string Size,
    string Floor,
    int MaxGuests,
    int NightlyRate,
    int MonthlyRate,
    List<string> Amenities,
    List<string> Features
);