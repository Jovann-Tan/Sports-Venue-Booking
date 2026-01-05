namespace SportsVenueBooking.Domain
{
    public class Venue : BaseDomainModel
    {
        public int CourtNumber { get; set; }
        public string? Address { get; set; }
        public string? Avaliability { get; set; }
        public DateTime TimeSlot { get; set; }
    }
}
