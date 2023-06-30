using FoodApp.Models.Models;

namespace FoodApp.Models.Interfaces
{
    public interface IMenu
    {
        DateTime CreatedAt { get; set; }
        int Id { get; set; }
        ICollection<Item> Items { get; }
        string Name { get; set; }
        Restaurant Restaurant { get; set; }
        int RestaurantId { get; set; }
        DateTime? UpdatedAt { get; set; }
    }
}