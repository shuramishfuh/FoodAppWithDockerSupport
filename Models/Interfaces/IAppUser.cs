using FoodApp.Models.Models;

namespace FoodApp.Models.Interfaces
{
    public interface IAppUser
    {
        ICollection<Address> Addresses { get; }
        ICollection<Card> Cards { get; }
        DateTime CreatedAt { get; set; }
        string Email { get; set; }
        bool EmailVerified { get; set; }
        int Id { get; set; }
        string UserName { get; set; }
        string Role { get; set; }
        string? RefreshToken { get; set; }
        bool RefreshTokenIsActive { get; set; }
        ICollection<Order> Orders { get; }
        string PasswordHash { get; set; }
        ICollection<Paypal> Paypals { get; }
        string PhoneNumber { get; set; }
        bool PhoneVerified { get; set; }
    }
}