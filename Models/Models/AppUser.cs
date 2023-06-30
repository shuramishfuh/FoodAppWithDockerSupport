using FoodApp.Models.Interfaces;

namespace FoodApp.Models.Models;


public partial class AppUser : IAppUser
{
    public int Id { get; set; }

    public string UserName { get; set; }

    public string Email { get; set; }

    public string PasswordHash { get; set; }

    public string PhoneNumber { get; set; }

    public bool EmailVerified { get; set; } = false;

    public bool PhoneVerified { get; set; } = false;

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public virtual ICollection<Address> Addresses { get; } = new List<Address>();

    public virtual ICollection<Card> Cards { get; } = new List<Card>();

    public virtual ICollection<Order> Orders { get; } = new List<Order>();

    public virtual ICollection<Paypal> Paypals { get; } = new List<Paypal>();
    public string Role { get; set; }
    public string? RefreshToken { get; set; } = null;
    public bool RefreshTokenIsActive { get; set; } = true;
}
