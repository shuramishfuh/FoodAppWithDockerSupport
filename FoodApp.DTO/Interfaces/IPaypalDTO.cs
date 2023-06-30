namespace FoodApp.DTO.Interfaces
{
    public interface IPaypalDTO
    {
        string AccessToken { get; set; }
        string Email { get; set; }
        int Id { get; set; }
        string RefreshToken { get; set; }
        DateTime TokenExpiration { get; set; }
        int UserId { get; set; }
    }
}