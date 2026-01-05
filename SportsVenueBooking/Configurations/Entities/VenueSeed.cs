using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsVenueBooking.Domain;

namespace SportsVenueBooking.Configurations.Entities
{
    public class VenueSeed : IEntityTypeConfiguration<Venue>
    {
        public void Configure(EntityTypeBuilder<Venue> builder)
        {
            builder.HasData(
                new Venue
                {
                    Id = 1,
                    CourtNumber = 1,
                    Address = "Over There",
                    Avaliability = "Avaliable",
                    TimeSlot = DateTime.Now,
                },
                new Venue
                {
                    Id = 2,
                    CourtNumber = 2,
                    Address = "Over There",
                    Avaliability = "Unavaliable",
                    TimeSlot = DateTime.Now,
                },
                new Venue
                {
                    Id = 3,
                    CourtNumber = 2,
                    Address = "Over Here",
                    Avaliability = "Avaliable",
                    TimeSlot = DateTime.Now,
                }
            );
        }
    }
}
