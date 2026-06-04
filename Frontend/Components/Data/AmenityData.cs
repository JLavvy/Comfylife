using Comfylife.Frontend.Models;

namespace Comfylife.Frontend.Data;

public static class AmenityData
{
    public static readonly List<Amenity> Amenities =
    [
        new("fa-solid fa-dumbbell", "Fully Equipped Gym", "On-site fitness facility for all guests."),
        new("fa-solid fa-utensils", "Fitted Kitchen", "Open-plan kitchen with full appliances."),
        new("fa-solid fa-tv", "Smart TV & Netflix", "65\"–70\" Smart TVs with a Netflix account."),
        new("fa-solid fa-wifi", "Fast WiFi", "Free, high-speed internet throughout."),
        new("fa-solid fa-fire", "Solar / Backup Heating", "Reliable hot water, day and night."),
        new("fa-solid fa-shirt", "Laundry Area", "In-unit laundry for longer stays."),
        new("fa-solid fa-shield-halved", "24/7 Security", "CCTV, intercom and electric fence."),
        new("fa-solid fa-bolt", "Power Backup", "Generator backup keeps you running."),
        new("fa-solid fa-droplet", "Borehole Water", "Constant water supply, on-site."),
        new("fa-solid fa-car", "Private Parking", "Secure parking on the premises."),
        new("fa-solid fa-building", "High-Speed Lifts", "Quick access to upper floors."),
        new("fa-solid fa-tree", "Landscaped Gardens", "Green grounds and a rooftop grill.")
    ];
}