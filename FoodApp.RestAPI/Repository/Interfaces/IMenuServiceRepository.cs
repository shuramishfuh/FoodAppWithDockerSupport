using FoodApp.DTO.Interfaces;
using FoodApp.Models.Interfaces;

namespace FoodApp.RestAPI.Repository.Interfaces
{
    public interface IMenuServiceRepository
    {
        IMenu? GetMenuById(int id);
        IEnumerable<IMenu> GetAllMenusWithResturantId(int id);
        bool DeleteMenu(int id);
        IMenu? UpdateMenu(IMenuDTO menu);
        IMenu CreateMenu(IMenuDTO menu);
        int SaveCommit();
    }
}
