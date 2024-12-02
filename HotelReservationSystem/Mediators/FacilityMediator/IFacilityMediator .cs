using HotelReservationSystem.DTO.Facility;
using HotelReservationSystem.ViewModels.FacilitiesViewModel;

namespace HotelReservationSystem.Mediators.FacilityMediator;

public interface IFacilityMediator
{
    IEnumerable<FacilityToReturnDto> getAllFacilities();
    FacilityToReturnDto GetById(int id);
    FacilityToReturnDto Add(CreateFacilityViewModel viewModel);
    FacilityToReturnDto Update(int id, CreateFacilityViewModel viewModel);
    bool DeleteFacility(int id);
}
