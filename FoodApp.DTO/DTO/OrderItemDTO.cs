using FoodApp.DTO.Interfaces;

namespace FoodApp.DTO.DTO;

public partial class OrderItemDTO : IOrderItemDTO
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public int ItemId { get; set; }

    public int Quantity { get; set; }

}
