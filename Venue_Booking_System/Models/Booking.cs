using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using VenueBookingSystem.Models;

namespace Venue_Booking_System.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

        [Required(ErrorMessage = "Please select an event.")]
        public int EventId { get; set; }
        public Event? Event { get; set; }

        [Required(ErrorMessage = "Please select a venue.")]
        public int VenueId { get; set; }
        public Venue? Venue { get; set; }

        [Required]
        public DateTime BookingDate { get; set; }
    }
}

