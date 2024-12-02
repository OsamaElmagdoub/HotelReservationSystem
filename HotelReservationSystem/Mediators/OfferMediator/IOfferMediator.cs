using HotelReservationSystem.DTO.Offer;

namespace HotelReservationSystem.Mediators.OfferMediator
{
    public interface IOfferMediator
    {
        IEnumerable<Offer> GetAll();
        Offer Get(int id);
        Task<OfferDTO> Add(AddOfferDto addOfferDTO);
        Task<OfferDTO> Update(int id, EditOfferDto editOfferDTO);
        bool Delete(int id);

    }

}
