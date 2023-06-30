using FoodApp.Models.Interfaces;

namespace FoodApp.Models.Models;


public partial class Card : ICard
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string NameOnCard { get; set; } = null!;

    public string CardNumber { get; set; } = null!;

    public string ExpirationDate { get; set; } = null!;

    public string Cvv { get; set; } = null!;

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public virtual AppUser User { get; set; } = null!;
}
