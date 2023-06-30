using FoodApp.Models.Interfaces;

namespace FoodApp.Models.Models;



public partial class Menu : IMenu
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int RestaurantId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Item> Items { get; } = new List<Item>();

    public virtual Restaurant Restaurant { get; set; } = null!;
}
