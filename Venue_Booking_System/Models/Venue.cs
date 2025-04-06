using System.ComponentModel.DataAnnotations;
using Venue_Booking_System.Models;

namespace VenueBookingSystem.Models
{
    public class Venue
    {
        [Key]
        public int VenueId { get; set; }

       
        public string VenueName { get; set; }

        
        public string Location { get; set; }

       
        public int Capacity { get; set; }

        public string? ImageUrl { get; set; }

        public List<Booking> Bookings { get; set; } = new();
      }
    }