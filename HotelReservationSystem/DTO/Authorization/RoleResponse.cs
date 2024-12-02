namespace HotelReservationSystem.DTO.Authorization;

public record RoleResponse(
    string Id,
    string Name,
    bool IsDeleted
);