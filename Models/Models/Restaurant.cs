using FoodApp.Models.Interfaces;

namespace FoodApp.Models.Models;


public partial class Restaurant : IRestaurant
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string LogoUrl { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<Menu> Menus { get; } = new List<Menu>();
}
