namespace SportsVenueBooking.Domain
{
    public class Staff : BaseDomainModel
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public int ContactNumber { get; set; }
        public int VenueId { get; set; }
    }
}
