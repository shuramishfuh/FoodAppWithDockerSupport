using FoodApp.DTO.DTO;
using FoodApp.RestAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FoodApp.RestAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly ICardServiceRepository _repository;

        public CardController(ICardServiceRepository repository)
        {
            _repository = repository;
        }


        [HttpGet("{id}")]
        public ActionResult<CardDTO> GetCardById(int id)
        {
            var card = _repository.GetCardById(id);
            if (card == null)
            {
                return NotFound();
            }
            return (CardDTO)card;
        }


        [HttpGet("user/{userId}")]
        public ActionResult<IEnumerable<CardDTO>> GetAllCardsWithUserId(int userId)
        {
            var cards = _repository.GetAllCardsWithUserId(userId);
            if (cards == null)
            {
                return NotFound();
            }
            return Ok(cards);
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<CardDTO> CreateCard(CardDTO card)
        {
            if (card == null)
            {
                return BadRequest();
            }

            var createdCard = _repository.CreateCard(card);
            if (createdCard == false)
            {
                return BadRequest();
            }
            return CreatedAtAction(nameof(GetCardById), new { id = card.Id }, card);
        }


        [HttpPut("{id}")]
        public ActionResult<CardDTO> UpdateCard(CardDTO card)
        {
            if (card == null) { return BadRequest(); }

            var existingCard = _repository.GetCardById(card.Id);
            if (existingCard == null)
            {
                return NotFound();
            }

            var updatedCard = _repository.UpdateCard(card);
            if (updatedCard == false)
            {
                return BadRequest();
            }

            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteCard(int id)
        {
            var existingCard = _repository.GetCardById(id);
            if (existingCard == null)
            {
                return NotFound();
            }

            if (!_repository.DeleteCard(id))
            {
                return BadRequest();
            }

            return NoContent();
        }
    }
}
