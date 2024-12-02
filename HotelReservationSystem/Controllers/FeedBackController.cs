using HotelReservationSystem.DTO.FeedBack;
using HotelReservationSystem.Mediators.FeedBackMediator;
using Microsoft.AspNetCore.Mvc;

namespace HotelReservationSystem.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FeedBacksController : ControllerBase
	{
		private readonly IFeedBackMediator _feedBackMediator;

		public FeedBacksController(IFeedBackMediator feedBackMediator)
		{
			_feedBackMediator = feedBackMediator;
		}

		
		[HttpGet]
		public ActionResult<IEnumerable<FeedBack>> GetFeedBacks()
		{
			return Ok(_feedBackMediator.GetAll());
		}

		[HttpGet("{id}")]
		public ActionResult<FeedBack> GetFeedBack(int id)
		{
			var feedback = _feedBackMediator.Get(id);

			if (feedback == null)
			{
				return NotFound();
			}

			return Ok(feedback);
		}

		[HttpPost]
		public async Task<ActionResult<FeedBackDto>> PostFeedBack(AddFeedBackDto addFeedBackDto)
		{
			var feedback = await _feedBackMediator.Add(addFeedBackDto);
			return CreatedAtAction(nameof(GetFeedBack), new { id = feedback.Id}, feedback);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> PutFeedBack(int id, EditFeedBackDto editFeedBackDto)
		{
			try
			{
				var updatedFeedback = await _feedBackMediator.Update(id, editFeedBackDto);
				return Ok(updatedFeedback);
			}
			catch (KeyNotFoundException)
			{
				return NotFound();
			}
		}

		[HttpDelete("{id}")]
		public ActionResult<bool> DeleteFeedBack(int id)
		{
			var deleted = _feedBackMediator.Delete(id);
			if (!deleted)
			{
				return Ok(false);
			}

			return Ok(true);
		}
	}
}
