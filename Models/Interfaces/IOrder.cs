using FoodApp.Models.Models;

namespace FoodApp.Models.Interfaces
{
    public interface IOrder
    {
        int DeliveryAddressId { get; set; }
        decimal DeliveryFee { get; set; }
        int Id { get; set; }
        DateTime OrderDate { get; set; }
        ICollection<OrderItem> OrderItems { get; }
        string OrderStatus { get; set; }
        string PaymentStatus { get; set; }
        string PaymentType { get; set; }
        decimal TotalAmount { get; set; }
        AppUser User { get; set; }
        int UserId { get; set; }
    }
}