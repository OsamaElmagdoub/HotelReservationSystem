namespace HotelReservationSystem.Services.Authorization;

public interface IJwtProvider
{
    (string token, int expiresIn) GenerateToken(ApplicationUser user);
}