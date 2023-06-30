using FoodApp.DTO.DTO;
using FoodApp.Models.Interfaces;
using FoodApp.Models.Models;
using FoodApp.RestAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FoodApp.RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderServiceRepository _orderRepository;

        public OrderController(IOrderServiceRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        // GET api/order/5
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrderById(int id)
        {
            var order = _orderRepository.GetOrderById(id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        // GET api/order/user/5
        [HttpGet("user/{userId}")]
        public async Task<IEnumerable<IOrder>> GetOrdersByUserIdAsync(int userId)
        {
            var orders = await _orderRepository.GetOrdersByUserIdAsync(userId);
            return orders;
        }

        // POST api/order
        [HttpPost]
        public async Task<ActionResult<OrderDTO>> CreateOrderAsync(OrderDTO order)
        {
            if (order == null)
            {
                return BadRequest();
            }

            var createdOrder = await _orderRepository.CreateOrderAsync(order);
            if (createdOrder == null)
            {
                return BadRequest();
            }
            return CreatedAtAction(nameof(GetOrderById), new { id = createdOrder.Id }, createdOrder);
        }

        // DELETE api/order/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteOrderAsync(int id)
        {
            var orderToDelete = _orderRepository.GetOrderById(id);
            if (orderToDelete == null)
            {
                return NotFound();
            }

            var result = await _orderRepository.DeleteOrderAsync(id);

            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        // PUT api/order
        [HttpPut]
        public async Task<ActionResult<Order>> UpdateOrderAsync(OrderDTO order)
        {
            if (order == null)
            {
                return BadRequest();
            }

            var updatedOrder = await _orderRepository.UpdateOrderAsync(order);

            if (updatedOrder == null)
            {
                return NotFound();
            }

            return updatedOrder;
        }
    }
}
