using FoodApp.DTO.DTO;
using FoodApp.DTO.Interfaces;
using FoodApp.Models.Models;
using FoodApp.ORM;
using FoodApp.RestAPI.Repository.Interfaces;

namespace FoodApp.RestAPI.Repository
{
    public class ItemServiceRepository : IItemServiceRepository
    {
        private readonly FoodAppContext _context;

        public ItemServiceRepository(FoodAppContext context)
        {
            _context = context;
        }

        public Item? GetItemById(int id)
        {
            var entity = _context.Items.FirstOrDefault(x => x.Id == id);

            if (entity == null)
            {
                return null;
            }
            return entity;
        }

        public IEnumerable<Item> GetAllItemsWithMenuId(int menuId)
        {
            return _context
                .Items
                .Where(x => x.MenuId == menuId)
                .ToList();
        }

        public bool DeleteItem(int id)
        {
            var entity = _context.Items.FirstOrDefault(x => x.Id == id);

            if (entity == null)
            {
                return false;
            }

            _context.Items.Remove(entity);
            _context.SaveChanges();

            return true;
        }

        public bool UpdateItem(IItemDTO item)
        {
            var entity = _context.Items.FirstOrDefault(x => x.Id == item.Id);

            if (entity == null)
            {
                return false;
            }

            entity.Name = item.Name;
            entity.Description = item.Description;
            entity.Price = item.Price;
            entity.ImageUrl = item.ImageUrl;
            entity.MenuId = item.MenuId;

            _context.SaveChanges();

            return true;
        }

        public bool CreateItem(ItemDTO item)
        {

            _context.Items.Add(item);
            _context.SaveChanges();

            return true;
        }

        public int SaveCommit()
        {
            return _context.SaveChanges();
        }
    }

}
