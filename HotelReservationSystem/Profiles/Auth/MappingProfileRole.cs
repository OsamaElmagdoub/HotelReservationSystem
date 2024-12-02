using HotelReservationSystem.DTO.Authorization;

namespace HotelReservationSystem.Profiles.Auth;

public class MappingProfileRole : Profile
{
    public MappingProfileRole()
    {
        CreateMap<ApplicationRole, RoleResponse>();
    }
}
