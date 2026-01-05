using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SportsVenueBooking.Configurations.Entities;
using SportsVenueBooking.Data;

namespace SportsVenueBooking.Data
{
    public class SportsVenueBookingContext(DbContextOptions<SportsVenueBookingContext> options) : IdentityDbContext<SportsVenueBookingUser>(options)
    {
        public DbSet<SportsVenueBooking.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<SportsVenueBooking.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<SportsVenueBooking.Domain.Payment> Payment { get; set; } = default!;
        public DbSet<SportsVenueBooking.Domain.Staff> Staff { get; set; } = default!;
        public DbSet<SportsVenueBooking.Domain.Venue> Venue { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new VenueSeed());
        }
    }
}
