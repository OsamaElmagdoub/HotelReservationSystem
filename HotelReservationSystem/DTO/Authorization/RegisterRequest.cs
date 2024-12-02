namespace HotelReservationSystem.DTO.Authorization;

public record RegisterRequest(
    string Email,
    string Password,
    string FName,
    string LName
);
