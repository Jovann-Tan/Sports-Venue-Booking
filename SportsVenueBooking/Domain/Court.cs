namespace SportsVenueBooking.Domain
{
    public class Court : BaseDomainModel
    {
        public string? Sport { get; set; }
        public int VenueId { get; set; }
    }
}
