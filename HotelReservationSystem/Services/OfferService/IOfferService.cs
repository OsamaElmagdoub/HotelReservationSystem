using HotelReservationSystem.DTO.Offer;

namespace HotelReservationSystem.Services.OfferService
{
    public interface IOfferService
    {
        IEnumerable<Offer> GetAll();
        Offer Get(int id);
        Task<Offer> AddAsync(AddOfferDto addOfferDTO);
        Task<Offer> UpdateAsync(int id, AddOfferDto addOfferDTO);
        void Delete(int id);

    }

}
