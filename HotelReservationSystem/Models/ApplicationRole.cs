using Microsoft.AspNetCore.Identity;

namespace HotelReservationSystem.Models;

public class ApplicationRole : IdentityRole
{
    public bool IsDefault { get; set; }
    public bool IsDeleted { get; set; }
}