using FoodApp.Models.Interfaces;

namespace FoodApp.Models.Models;


public partial class Paypal : IPaypal
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Email { get; set; } = null!;

    public string AccessToken { get; set; } = null!;

    public string RefreshToken { get; set; } = null!;

    public DateTime TokenExpiration { get; set; }

    public virtual AppUser User { get; set; } = null!;
}
