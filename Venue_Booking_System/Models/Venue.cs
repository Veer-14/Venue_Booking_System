using System.ComponentModel.DataAnnotations;
using Venue_Booking_System.Models;

namespace VenueBookingSystem.Models
{
    public class Venue
    {
        [Key]
        public int VenueId { get; set; }

        [Required(ErrorMessage = "Venue name is required")]
        public string VenueName { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Capacity must be a positive number")]
        public int Capacity { get; set; }

        public string? ImageUrl { get; set; }

        public List<Booking> Bookings { get; set; } = new();
      }
    }