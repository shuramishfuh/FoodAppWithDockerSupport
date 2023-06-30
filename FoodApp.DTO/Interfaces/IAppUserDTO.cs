namespace FoodApp.DTO.Interfaces
{
    public interface IAppUserDTO
    {
        DateTime CreatedAt { get; set; }
        string Email { get; set; }
        bool EmailVerified { get; set; }
        int Id { get; set; }
        string Name { get; set; }
        string PasswordHash { get; set; }
        string? PhoneNumber { get; set; }
        bool PhoneVerified { get; set; }
    }
}

