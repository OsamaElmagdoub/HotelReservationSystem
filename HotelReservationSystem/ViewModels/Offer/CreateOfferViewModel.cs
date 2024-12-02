namespace HotelReservationSystem.ViewModels.Offer
{
    public class CreateOfferViewModel
    {
        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }
        public double Discount { get; set; }
        public List<int> RoomIds { get; set; } = new List<int>();
    }
}
