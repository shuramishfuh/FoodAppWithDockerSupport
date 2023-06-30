using FoodApp.Models.Models;

namespace FoodApp.Models.Interfaces
{
    public interface IRestaurant
    {
        string Address { get; set; }
        DateTime CreatedAt { get; set; }
        string Description { get; set; }
        string Email { get; set; }
        int Id { get; set; }
        string LogoUrl { get; set; }
        ICollection<Menu> Menus { get; }
        string Name { get; set; }
        string PhoneNumber { get; set; }
        DateTime UpdatedAt { get; set; }
    }
}