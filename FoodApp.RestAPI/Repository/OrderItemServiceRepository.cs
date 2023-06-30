using FoodApp.DTO.Interfaces;
using FoodApp.Models.Interfaces;
using FoodApp.Models.Models;
using FoodApp.ORM;
using FoodApp.RestAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodApp.RestAPI.Repository.Implementations
{
    public class OrderItemServiceRepository : IOrderItemServiceRepository
    {
        private readonly FoodAppContext _db;

        public OrderItemServiceRepository(FoodAppContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<IOrderItem>>? GetOrderItemsByOrderIdAsync(int orderId)
        {
            return await _db.OrderItems.Where(x => x.OrderId == orderId).ToListAsync();
        }

        public async Task<IOrderItem> CreateOrderItemAsync(IOrderItemDTO orderItem)
        {
            var newOrderItem = (OrderItem)orderItem;
            _db.OrderItems.Add(newOrderItem);
            await SaveCommitAsync();
            return newOrderItem;
        }

        public async Task<bool> DeleteOrderItemAsync(int id)
        {
            var orderItem = await _db.OrderItems.FindAsync(id);
            if (orderItem == null)
            {
                return false;
            }
            _db.OrderItems.Remove(orderItem);
            await SaveCommitAsync();
            return true;
        }

        public async Task<IOrderItem> UpdateOrderItemAsync(IOrderItemDTO orderItem)
        {
            var itemToUpdate = await _db.OrderItems.FindAsync(orderItem.Id);
            if (itemToUpdate == null)
            {
                return null;
            }
            itemToUpdate.Quantity = orderItem.Quantity;
            await SaveCommitAsync();
            return itemToUpdate;
        }

        public async Task<int> SaveCommitAsync()
        {
            return await _db.SaveChangesAsync();
        }
    }
}
