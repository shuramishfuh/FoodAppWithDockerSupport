using FoodApp.Models.Models;

namespace FoodApp.Models.Interfaces
{
    public interface IPaypal
    {

        string AccessToken { get; set; }
        string Email { get; set; }
        int Id { get; set; }
        string RefreshToken { get; set; }
        DateTime TokenExpiration { get; set; }
        AppUser User { get; set; }
        int UserId { get; set; }
    }
}