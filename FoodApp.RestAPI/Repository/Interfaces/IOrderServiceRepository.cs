using FoodApp.DTO.Interfaces;
using FoodApp.Models.Interfaces;
using FoodApp.Models.Models;

namespace FoodApp.RestAPI.Repository.Interfaces
{
    public interface IOrderServiceRepository
    {
        Order GetOrderById(int id);
        Task<IEnumerable<IOrder>> GetOrdersByUserIdAsync(int userId);
        Task<IOrder> CreateOrderAsync(IOrderDTO order);
        Task<bool> DeleteOrderAsync(int id);
        Task<Order>? UpdateOrderAsync(IOrderDTO order);
        Task<int> SaveCommitAsync();
    }
}
