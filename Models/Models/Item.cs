using FoodApp.Models.Interfaces;

namespace FoodApp.Models.Models;


public partial class Item : IItem
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Price { get; set; }

    public string ImageUrl { get; set; } = null!;

    public int MenuId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Menu Menu { get; set; } = null!;

    public virtual OrderItem? OrderItem { get; set; }

}
