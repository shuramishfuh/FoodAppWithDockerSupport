

using FoodApp.DTO.Interfaces;
using FoodApp.Models.Models;

namespace FoodApp.DTO.DTO;

public partial class ItemDTO : IItemDTO
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Price { get; set; }

    public string ImageUrl { get; set; } = null!;

    public int MenuId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public static implicit operator ItemDTO(Item item)
    {
        return new ItemDTO
        {
            Id = item.Id,
            Name = item.Name,
            Description = item.Description,
            Price = item.Price,
            ImageUrl = item.ImageUrl,
            MenuId = item.MenuId,
            CreatedAt = item.CreatedAt,
            UpdatedAt = item.UpdatedAt
        };
    }

    public static implicit operator Item(ItemDTO itemDTO)
    {
        return new Item
        {
            Id = itemDTO.Id,
            Name = itemDTO.Name,
            Description = itemDTO.Description,
            Price = itemDTO.Price,
            ImageUrl = itemDTO.ImageUrl,
            MenuId = itemDTO.MenuId,
            CreatedAt = itemDTO.CreatedAt,
            UpdatedAt = itemDTO.UpdatedAt
        };
    }

}
