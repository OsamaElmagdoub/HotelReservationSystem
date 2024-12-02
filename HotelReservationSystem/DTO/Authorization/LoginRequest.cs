namespace HotelReservationSystem.DTO.Authorization;

public record LoginRequest(
    string Email,
    string Password
);