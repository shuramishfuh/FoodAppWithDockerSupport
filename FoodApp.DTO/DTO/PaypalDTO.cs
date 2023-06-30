using FoodApp.DTO.Interfaces;

namespace FoodApp.DTO.DTO;

public partial class PaypalDTO : IPaypalDTO
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Email { get; set; } = null!;

    public string AccessToken { get; set; } = null!;

    public string RefreshToken { get; set; } = null!;

    public DateTime TokenExpiration { get; set; }

}
