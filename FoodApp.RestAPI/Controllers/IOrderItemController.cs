using FoodApp.DTO.DTO;
using FoodApp.RestAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FoodApp.RestAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderItemController : ControllerBase
    {
        private readonly IOrderItemServiceRepository _repository;

        public OrderItemController(IOrderItemServiceRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{orderId}")]
        public async Task<IActionResult> GetOrderItemsByOrderIdAsync(int orderId)
        {
            var orderItems = await _repository.GetOrderItemsByOrderIdAsync(orderId);
            return Ok(orderItems);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrderItemAsync(OrderItemDTO orderItem)
        {
            if (orderItem == null)
            {
                return BadRequest();
            }

            var createdOrderItem = await _repository.CreateOrderItemAsync(orderItem);
            if (createdOrderItem == null)
            {
                return BadRequest();
            }
            return CreatedAtRoute("GetOrderItem", new { id = createdOrderItem.Id }, createdOrderItem);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrderItemAsync(int id, OrderItemDTO orderItem)
        {
            if (orderItem == null || id != orderItem.Id)
            {
                return BadRequest();
            }

            var updatedOrderItem = await _repository.UpdateOrderItemAsync(orderItem);
            if (updatedOrderItem == null)
            {
                return BadRequest();
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderItemAsync(int id)
        {
            var result = await _repository.DeleteOrderItemAsync(id);
            if (result == false)
            {
                return BadRequest();
            }
            return NoContent();
        }
    }
}
