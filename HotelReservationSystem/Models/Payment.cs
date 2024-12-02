﻿namespace HotelReservationSystem.Models;

public class Payment:BaseModel
{
    public Reservation Reservation { get; set; } = null!;
    public DateTime PaymentDate { get; set; }
    public double Amount { get; set; }  
}
