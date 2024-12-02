﻿namespace HotelReservationSystem.DTO.Offer
{
    public class EditOfferDto
    {
            public int Id { get; set; }
            public DateTime Start_date { get; set; }
            public DateTime End_date { get; set; }
            public double Discount { get; set; }
            public List<int> RoomIds { get; set; } = new List<int>();
      
    }
}
