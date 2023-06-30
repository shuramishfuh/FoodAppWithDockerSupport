using FoodApp.Models.Interfaces;

namespace FoodApp.Models.Models;


public partial class OrderItem : IOrderItem
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public int ItemId { get; set; }

    public int Quantity { get; set; }

    public virtual Item IdNavigation { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
