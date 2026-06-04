namespace Comfylife.Frontend.Models;

public record ApartmentListing(
    int Id,
    string Name,
    string Tagline,
    string Image,
    string Location,
    string Description,
    int Bedrooms,
    string Beds,
    int Bathrooms,
    string Size,
    int MaxGuests,
    int NightlyRate,
    int MonthlyRate
);