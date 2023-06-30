namespace FoodApp.DTO.Interfaces
{
    public interface IMenuDTO
    {
        DateTime CreatedAt { get; set; }
        int Id { get; set; }
        string Name { get; set; }
        int RestaurantId { get; set; }
        DateTime? UpdatedAt { get; set; }
    }
}