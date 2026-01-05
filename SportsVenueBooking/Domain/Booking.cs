namespace SportsVenueBooking.Domain
{
    public class Booking : BaseDomainModel
    {
        public DateTime TimeSlot { get; set; }
        public string? Sport { get; set; }
        public int VenueId { get; set; }
        public int CustomerId { get; set; }
        public int PaymentId { get; set; }
    }
}
