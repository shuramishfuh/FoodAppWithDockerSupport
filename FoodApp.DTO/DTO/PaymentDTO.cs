using FoodApp.DTO.Interfaces;

namespace FoodApp.DTO.DTO;

public partial class PaymentDTO : IPaymentDTO
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public decimal Amount { get; set; }

    public int PaymentMethodId { get; set; }

    public int StatusId { get; set; }

    public DateTime CreatedAt { get; set; }
}
