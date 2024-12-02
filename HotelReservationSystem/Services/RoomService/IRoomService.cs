using HotelReservationSystem.DTO.Room;

namespace HotelReservationSystem.Services.RoomService;

public interface IRoomService
{
    IEnumerable<RoomToReturnDto> GetAll();
    RoomToReturnDto GetById(int id);
    Task<RoomToReturnDto> AddAsync(RoomDTO roomDTO );
    Task<RoomToReturnDto> UpdateAsync(int id, RoomDTO roomDTO);
    bool Delete(int id);
    double CalculateTotalPrice(int roomId);
}
