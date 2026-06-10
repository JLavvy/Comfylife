using Comfylife.Frontend.Models;

namespace Comfylife.Frontend.Data;

public static class ApartmentData
{
    public static readonly List<ApartmentListing> Apartments = new()
    {
        new ApartmentListing(
            Id: 1,
            Name: "Prince House",
            Tagline: "ELEGANT 2-BEDROOM .7TH FLOOR",
            Image: "images/Dream/rooftop.jpeg",
            Location: "Denis Pritt Road, Kilimani",
            Area: "Kilimani",
            Description: "Elegant fully furnished 2-bedroom apartment in Kilimani, ideal for short stays and monthly bookings.",
            LongDescription: "Prince House is an elegant fully furnished 2-bedroom apartment located on Denis Pritt Road in Kilimani. It is designed for comfort, convenience and stylish living, making it ideal for both short stays and extended bookings.",
            Bedrooms: 2,
            Beds: "2 Beds",
            Bathrooms: 2,
            Size: "Spacious",
            Floor: "7th Floor",
            MaxGuests: 4,
            NightlyRate: 6500,
            MonthlyRate: 180000,
            Amenities: new List<string>
            {
                "Fully Furnished",
                "Fitted Kitchen",
                "Fast WiFi",
                "Smart TV",
                "Laundry Area",
                "Balcony"
            },
            Features: new List<string>
            {
                "24/7 Security",
                "CCTV Surveillance",
                "Private Parking",
                "Backup Water",
                "Power Backup",
                "Secure Access"
            },
            Images: new List<string>
            {
                "images/Dream/rooftop.jpeg",
                "images/Dream/balcony.jpeg",
                // add more Prince House images here
            }
        ),

        new ApartmentListing(
            Id: 2,
            Name: "Dream House",
            Tagline: "MODERN 2-BEDROOM .2ND FLOOR",
            Image: "images/Dream/balcony.jpeg",
            Location: "Denis Pritt Road, Kilimani",
            Area: "Kilimani",
            Description: "Modern fully furnished 2-bedroom apartment with comfort, style and convenience.",
            LongDescription: "Dream House is a modern fully furnished 2-bedroom apartment located in Kilimani. The apartment offers a clean, comfortable and stylish stay with essential amenities for guests booking by the night or by the month.",
            Bedrooms: 2,
            Beds: "2 Beds",
            Bathrooms: 2,
            Size: "Spacious",
            Floor: "2nd Floor",
            MaxGuests: 4,
            NightlyRate: 9500,
            MonthlyRate: 250000,
            Amenities: new List<string>
            {
                "Fully Furnished",
                "Fitted Kitchen",
                "Fast WiFi",
                "Smart TV",
                "Laundry Area",
                "Balcony"
            },
            Features: new List<string>
            {
                "24/7 Security",
                "CCTV Surveillance",
                "Private Parking",
                "Backup Water",
                "Power Backup",
                "Secure Access"
            },
            Images: new List<string>
            {
                "images/Dream/balcony.jpeg",
                "images/Dream/rooftop.jpeg",
                "images/Dream/dining.jpeg",
                "images/Dream/broom1.jpeg",
                "images/Dream/broom2.jpeg",
                "images/Dream/Kitchen.jpeg",
                "images/Dream/washroom.jpeg",
                "images/Dream/gym.jpeg"
                // add more Dream House images here
            }
        ),

        new ApartmentListing(
            Id: 3,
            Name: "Ndovu House",
            Tagline: "EXECUTIVE 3-BEDROOM .7TH FLOOR",
            Image: "images/Dream/rooftop.jpeg",
            Location: "Kindaruma Road, Kilimani",
            Area: "Kilimani",
            Description: "Executive 3-bedroom apartment designed for families, groups and longer stays.",
            LongDescription: "Ndovu House is an executive fully furnished 3-bedroom apartment located on Kindaruma Road in Kilimani. It is ideal for families, groups and longer stays, offering more room, comfort and convenience.",
            Bedrooms: 3,
            Beds: "3 Beds",
            Bathrooms: 3,
            Size: "Large",
            Floor: "7th Floor",
            MaxGuests: 6,
            NightlyRate: 13500,
            MonthlyRate: 350000,
            Amenities: new List<string>
            {
                "Fully Furnished",
                "Fitted Kitchen",
                "Fast WiFi",
                "Smart TV",
                "Laundry Area",
                "Balcony"
            },
            Features: new List<string>
            {
                "24/7 Security",
                "CCTV Surveillance",
                "Private Parking",
                "Backup Water",
                "Power Backup",
                "Secure Access"
            },
            Images: new List<string>
            {
                "images/Dream/rooftop.jpeg",
                "images/Dream/balcony.jpeg",
                // add more Ndovu House images here
            }
        )
    };
}