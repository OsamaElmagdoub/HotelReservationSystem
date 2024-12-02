using HotelReservationSystem.DTO.RoomFacility;

namespace HotelReservationSystem.Profiles.RoomFacilityProfiles;

public class RoomFcaility : Profile
{
    public RoomFcaility()
    {
        CreateMap<RoomFacilityDto,FacilityRoom>();
    }
}
