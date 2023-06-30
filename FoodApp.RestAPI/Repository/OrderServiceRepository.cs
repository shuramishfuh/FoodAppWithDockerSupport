using FoodApp.DTO.Interfaces;
using FoodApp.Models.Interfaces;
using FoodApp.Models.Models;
using FoodApp.ORM;
using FoodApp.RestAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodApp.RestAPI.Repository
{
    public class OrderServiceRepository : IOrderServiceRepository
    {
        private readonly FoodAppContext _db;

        public OrderServiceRepository(FoodAppContext db)
        {
            _db = db;
        }

        public async Task<IOrder> CreateOrderAsync(IOrderDTO order)
        {
            try
            {
                Order _ = (Order)order;
                _db.Orders.Add(_);
                await SaveCommitAsync();
                return _;
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> DeleteOrderAsync(int id)
        {
            try
            {
                var item = await _db.Orders.FindAsync(id);
                if (item != null)
                {
                    _db.Orders.Remove(item);
                    await SaveCommitAsync();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public async Task<Order>? UpdateOrderAsync(IOrderDTO order)
        {
            try
            {
                Order _ = (Order)order;
                _db.Entry(_).State = EntityState.Modified;
                await SaveCommitAsync();
                return _;
            }
            catch
            {
                return null;
            }
        }

        public async Task<IEnumerable<IOrder>> GetOrdersByUserIdAsync(int userId)
        {
            var items = await _db.Orders
                .Where(x => x.UserId == userId)
                .ToListAsync();

            return items.Select(x => (IOrder)x).ToList();
        }

        public Order? GetOrderById(int id)
        {
            return _db.Orders.FirstOrDefault(x => x.Id == id);
        }

        public async Task<int> SaveCommitAsync()
        {
            return await _db.SaveChangesAsync();
        }

    }
}

