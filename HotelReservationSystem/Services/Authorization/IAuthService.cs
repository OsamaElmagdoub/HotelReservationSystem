using HotelReservationSystem.DTO.Authorization;

namespace HotelReservationSystem.Services.Authorization;

public interface IAuthService
{
    Task<AuthResponse?> GetTokenAsync(string email, string password, CancellationToken cancellationToken = default);
}
