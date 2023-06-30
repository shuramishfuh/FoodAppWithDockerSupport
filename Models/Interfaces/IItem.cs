using FoodApp.Models.Models;

namespace FoodApp.Models.Interfaces
{
    public interface IItem
    {
        DateTime CreatedAt { get; set; }
        string Description { get; set; }
        int Id { get; set; }
        string ImageUrl { get; set; }
        Menu Menu { get; set; }
        int MenuId { get; set; }
        string Name { get; set; }
        OrderItem? OrderItem { get; set; }
        decimal Price { get; set; }
        DateTime? UpdatedAt { get; set; }
    }
}