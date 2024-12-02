﻿using HotelReservationSystem.DTO.Offer;
using HotelReservationSystem.Exceptions.Error;
using HotelReservationSystem.Mediators.OfferMediator;
using HotelReservationSystem.ViewModels.Offer;
using HotelReservationSystem.ViewModels.ResultViewModel;
using Microsoft.EntityFrameworkCore;

namespace HotelReservationSystem.Controllers
{
    public class OffersController : BaseApiController
    {
        private readonly IOfferMediator _offerMediator;

        public OffersController(IOfferMediator offerMediator)
        {
            _offerMediator = offerMediator;
        }

        [HttpPost("")]
        public async Task<ResultViewModel<OfferViewModel>> AddOffer([FromBody] CreateOfferViewModel viewModel)
        {
            var createOfferDto = viewModel.MapOne<AddOfferDto>();
            var offerToReturnDto = await _offerMediator.Add(createOfferDto);
            var offerViewModel = offerToReturnDto.MapOne<OfferViewModel>();
            return ResultViewModel<OfferViewModel>.Sucess(offerViewModel);
        }

        [HttpPut("{id}")]
        public async Task<ResultViewModel<OfferViewModel>> UpdateRoom([FromRoute] int id, [FromBody] CreateOfferViewModel viewModel)
        {
            var createOfferDto = viewModel.MapOne<EditOfferDto>();
            var offerToreturnDTO = await _offerMediator.Update(id, createOfferDto);
            var offerViewModel = offerToreturnDTO.MapOne<OfferViewModel>();

            return ResultViewModel<OfferViewModel>.Sucess(offerViewModel);
        }


        [HttpDelete("{id}")]
        public ResultViewModel<bool> DeleteOffer([FromRoute] int id)
        {
            var isDeleted = _offerMediator.Delete(id);

            if (isDeleted)
            {
                return ResultViewModel<bool>.Sucess(true, "Offer is Deleted");
            }

            return ResultViewModel<bool>.Faliure(ErrorCode.ResourceNotFound, "Offer is not existed");
        }
    }
}