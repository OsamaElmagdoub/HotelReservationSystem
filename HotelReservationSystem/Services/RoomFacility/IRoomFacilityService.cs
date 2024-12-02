using HotelReservationSystem.DTO.RoomFacility;
using HotelReservationSystem.Models;

namespace HotelReservationSystem.Services.RoomFacilityService;

public interface IRoomFacilityService
{
    List<int> GetFacilityIdsByRoomId(int roomId);
    List<int> AddRoomFacility(int roomId, List<int> roomFacilityIds);
    List<int> UpdateRoomFacility(int roomId, List<int> roomFacilityIds);
    bool DeleteRoomFacilitiesByRoomId(int RoomId, List<int> FacilitiesIds = null);
}
