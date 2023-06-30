

using FoodApp.DTO.Interfaces;

namespace FoodApp.DTO.DTO;

public partial class MenuDTO : IMenuDTO
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int RestaurantId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
