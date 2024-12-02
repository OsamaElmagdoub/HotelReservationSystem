using HotelReservationSystem.DTO.Reservation;

namespace HotelReservationSystem.Mediators.ReservationMediator
{
    public interface IReservationMediator
    {
        ReservationToReturnDto GetById(int id);
        IEnumerable<ReservationToReturnDto> GetAllReservation();
        ReservationToReturnDto Add(ReservationDto reservationDto);
        ReservationToReturnDto Update(int id, ReservationDto reservationDto);
        bool CancelReservation(int id);

    }
}
