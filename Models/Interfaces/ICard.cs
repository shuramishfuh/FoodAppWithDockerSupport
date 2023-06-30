using FoodApp.Models.Models;

namespace FoodApp.Models.Interfaces
{
    public interface ICard
    {

        string CardNumber { get; set; }
        DateTime CreatedAt { get; set; }
        string Cvv { get; set; }
        string ExpirationDate { get; set; }
        int Id { get; set; }
        string NameOnCard { get; set; }
        AppUser User { get; set; }
        int UserId { get; set; }
    }
}