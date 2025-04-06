using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VenueBookingSystem.Models;
using Venue_Booking_System.Models;

namespace Venue_Booking_System.Data
{
    public class Venue_Booking_SystemContext : DbContext
    {
        public Venue_Booking_SystemContext (DbContextOptions<Venue_Booking_SystemContext> options)
            : base(options)
        {
        }

        public DbSet<VenueBookingSystem.Models.Venue> Venue { get; set; } = default!;
        public DbSet<Event> Event { get; set; } = default!;
        public DbSet<Venue_Booking_System.Models.Booking> Booking { get; set; } = default!;
    }
}
