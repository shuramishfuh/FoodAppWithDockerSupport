namespace FoodApp.DTO.Interfaces
{
    public interface IRestaurantDTO
    {
        string Address { get; set; }
        DateTime CreatedAt { get; set; }
        string Description { get; set; }
        string Email { get; set; }
        int Id { get; set; }
        string LogoUrl { get; set; }
        string Name { get; set; }
        string PhoneNumber { get; set; }
        DateTime UpdatedAt { get; set; }
    }
}