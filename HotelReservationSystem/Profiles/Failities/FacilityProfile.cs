
namespace HotelReservationSystem.Profiles.FailitiesProfiles;

public class FacilityProfile:Profile
{
    public FacilityProfile()
    {
        CreateMap<FacilityDto,Facility>();
        CreateMap<CreateFacilityViewModel, FacilityDto>();
        CreateMap<Facility, FacilityToReturnDto>();

    }
}
