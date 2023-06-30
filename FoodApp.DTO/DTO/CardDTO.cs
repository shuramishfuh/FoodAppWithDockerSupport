
using FoodApp.DTO.Interfaces;
using FoodApp.Models.Models;

namespace FoodApp.DTO.DTO;

public partial class CardDTO : ICardDTO
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string NameOnCard { get; set; } = null!;

    public string CardNumber { get; set; } = null!;

    public string ExpirationDate { get; set; } = null!;

    public string Cvv { get; set; } = null!;


    public static implicit operator CardDTO(Card card) => new CardDTO
    {
        Id = card.Id,
        UserId = card.UserId,
        NameOnCard = card.NameOnCard,
        Cvv = card.Cvv,
        ExpirationDate = card.ExpirationDate,
        CardNumber = card.CardNumber,
    };


    public static implicit operator Card(CardDTO card) => new Card
    {
        Id = card.Id,
        UserId = card.UserId,
        NameOnCard = card.NameOnCard,
        Cvv = card.Cvv,
        ExpirationDate = card.ExpirationDate,
        CardNumber = card.CardNumber,
    };
}
