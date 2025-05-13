using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using VenueBookingSystem.Models;
using Venue_Booking_System.Models;

public class Event
{
    [Key]
    public int EventId { get; set; }

    [Required(ErrorMessage = "Event name is required")]
    public string EventName { get; set; }

    [Required(ErrorMessage = "Venue date is required")]
    public DateTime EventDate { get; set; }

    [Required(ErrorMessage = "Event description is required")]
    public string Description { get; set; }

    public List<Booking> Bookings { get; set; } = new();
}
