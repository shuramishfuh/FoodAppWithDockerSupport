
using FoodApp.DTO.Interfaces;

namespace FoodApp.DTO.DTO;

public partial class PaymentMethodDTO : IPaymentMethodDTO
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

}
