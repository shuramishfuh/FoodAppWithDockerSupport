using FoodApp.DTO.Interfaces;
using FoodApp.Models.Interfaces;

namespace FoodApp.RestAPI.Repository.Interfaces
{
    public interface IOrderItemServiceRepository
    {
        public Task<IEnumerable<IOrderItem>>? GetOrderItemsByOrderIdAsync(int orderId);
        public Task<IOrderItem> CreateOrderItemAsync(IOrderItemDTO orderItem);
        public Task<bool> DeleteOrderItemAsync(int id);
        public Task<IOrderItem> UpdateOrderItemAsync(IOrderItemDTO orderItem);
        public Task<int> SaveCommitAsync();
    }
}
