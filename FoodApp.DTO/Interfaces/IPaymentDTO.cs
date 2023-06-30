namespace FoodApp.DTO.Interfaces
{
    public interface IPaymentDTO
    {
        decimal Amount { get; set; }
        DateTime CreatedAt { get; set; }
        int Id { get; set; }
        int OrderId { get; set; }
        int PaymentMethodId { get; set; }
        int StatusId { get; set; }
    }
}