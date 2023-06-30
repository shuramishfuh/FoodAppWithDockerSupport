using FoodApp.DTO.DTO;
using FoodApp.DTO.Interfaces;
using FoodApp.Models.Models;

namespace FoodApp.RestAPI.Repository.Interfaces
{
    public interface IItemServiceRepository
    {
        public Item? GetItemById(int id);
        public IEnumerable<Item> GetAllItemsWithMenuId(int menuId);
        public bool DeleteItem(int id);
        public bool UpdateItem(IItemDTO item);
        public bool CreateItem(ItemDTO item);
        public int SaveCommit();
    }
}
