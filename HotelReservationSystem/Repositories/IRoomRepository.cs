namespace HotelReservationSystem.Repositories;

public interface IRoomRepository: IRepository<Room>
{
    Room GetByIDWithInclude(int id);
}
