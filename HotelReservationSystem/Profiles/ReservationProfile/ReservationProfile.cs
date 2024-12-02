using HotelReservationSystem.DTO.Reservation;
using HotelReservationSystem.ViewModels.Reservation;

namespace HotelReservationSystem.Profiles.RepositoryProfile
{
	public class ReservationProfile : Profile
	{
		public ReservationProfile() 
		{
			CreateMap<ReservationDto, Reservation>();
			CreateMap<Reservation, ReservationToReturnDto>();
			CreateMap<CreateReservationViewModel, ReservationDto>();

		}
	}
}
