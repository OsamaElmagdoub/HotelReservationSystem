using System.Runtime.Serialization;

namespace HotelReservationSystem.Models;

public enum ReservationStatus
{
    [EnumMember(Value = "Pending")]
    Pending,

    [EnumMember(Value = "Confirmed")]
    Confirmed,

    [EnumMember(Value = "CheckedIn")]
    CheckedIn,

    [EnumMember(Value = "CheckedOut")]
    CheckedOut,

    [EnumMember(Value = "Cancelled")]
    Cancelled
}
