namespace FoodApp.DTO.Interfaces
{
    public interface ICardDTO
    {
        string CardNumber { get; set; }
        string Cvv { get; set; }
        string ExpirationDate { get; set; }
        int Id { get; set; }
        string NameOnCard { get; set; }
        int UserId { get; set; }

    }
}