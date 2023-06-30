namespace FoodApp.DTO.Interfaces
{
    public interface IOrderItemDTO
    {
        int Id { get; set; }
        int ItemId { get; set; }
        int OrderId { get; set; }
        int Quantity { get; set; }
    }
}