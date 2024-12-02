using HotelReservationSystem.DTO.Facility;

namespace HotelReservationSystem.Services.FacilitiesServices;

public interface IFacilitiesService
{
    FacilityToReturnDto GetById(int id);
    IEnumerable<FacilityToReturnDto> GetFacilities();
    FacilityToReturnDto Add(FacilityDto facilityDto);
    FacilityToReturnDto Update(int id, FacilityDto facilityDto);
    bool Delete(int id);
}
