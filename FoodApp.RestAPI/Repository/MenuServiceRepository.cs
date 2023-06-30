using FoodApp.DTO.Interfaces;
using FoodApp.Models.Interfaces;
using FoodApp.Models.Models;
using FoodApp.ORM;
using FoodApp.RestAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodApp.RestAPI.Repository
{
    public class MenuServiceRepository : IMenuServiceRepository
    {
        private readonly FoodAppContext _db;

        public MenuServiceRepository(FoodAppContext db)
        {
            _db = db;
        }

        public IMenu CreateMenu(IMenuDTO menu)
        {
            var newMenu = (Menu)menu;
            _db.Menus.Add(newMenu);
            SaveCommit();
            return newMenu;
        }

        public bool DeleteMenu(int id)
        {
            var menuToDelete = _db.Menus.Find(id);
            if (menuToDelete == null)
            {
                return false;
            }

            _db.Menus.Remove(menuToDelete);
            SaveCommit();
            return true;
        }

        public IMenu? GetMenuById(int id)
        {
            var menu = _db.Menus.Find(id);
            return menu;
        }

        public IEnumerable<IMenu> GetAllMenusWithResturantId(int id)
        {
            var menus = _db.Menus
                .Where(x => x.RestaurantId == id)
                .ToList();
            return menus;
        }

        public IMenu? UpdateMenu(IMenuDTO menu)
        {
            var menuToUpdate = _db.Menus.Find(menu.Id);
            if (menuToUpdate == null)
            {
                return null;
            }

            menuToUpdate.Name = menu.Name;
            menuToUpdate.RestaurantId = menu.RestaurantId;
            menuToUpdate.UpdatedAt = DateTime.UtcNow;

            _db.Entry(menuToUpdate).State = EntityState.Modified;
            SaveCommit();

            return menuToUpdate;
        }

        public int SaveCommit()
        {
            return _db.SaveChanges();
        }
    }
}
