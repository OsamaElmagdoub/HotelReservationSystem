namespace HotelReservationSystem.DTO.Authorization;

public record RoleDetailResponse(
    string Id,
    string Name,
    bool IsDeleted
);