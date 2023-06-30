namespace FoodApp.DTO.Interfaces
{
    public interface IOrderDTO
    {
        DateTime CreatedAt { get; set; }
        int Id { get; set; }
        int PaymentId { get; set; }
        int StatusId { get; set; }
        DateTime? UpdatedAt { get; set; }
        int UserId { get; set; }
    }
}