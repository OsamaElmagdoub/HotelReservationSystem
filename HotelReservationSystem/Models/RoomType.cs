using System.Runtime.Serialization;

namespace HotelReservationSystem.Models;

public enum RoomType
{
    [EnumMember(Value = "Single")]
    Single,

    [EnumMember(Value = "Double")]
    Double,

    [EnumMember(Value = "Triple")]
    Triple,

    [EnumMember(Value = "Suite")]
    Suite
}
