using FoodApp.Models.Models;

namespace FoodApp.Models.Interfaces
{
    public interface IOrderItem
    {
        int Id { get; set; }
        Item IdNavigation { get; set; }
        int ItemId { get; set; }
        Order Order { get; set; }
        int OrderId { get; set; }
        int Quantity { get; set; }
    }
}