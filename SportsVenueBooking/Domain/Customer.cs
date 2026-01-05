namespace SportsVenueBooking.Domain
{
    public class Customer : BaseDomainModel
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public int ContactNumber { get; set; }
    }
}
