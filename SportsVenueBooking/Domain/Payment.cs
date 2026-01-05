namespace SportsVenueBooking.Domain
{
    public class Payment : BaseDomainModel
    {
        public int CardNumber { get; set; }
        public string CardName { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int Code { get; set; }
    }
}
