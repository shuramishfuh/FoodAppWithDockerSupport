namespace FoodApp.DTO.Interfaces
{
    public interface ICreatUserDTO
    {

        string Email { get; set; }
        string UserName { get; set; }
        string Role { get; set; }
        string PasswordHash { get; set; }
        string PhoneNumber { get; set; }
    }
}
