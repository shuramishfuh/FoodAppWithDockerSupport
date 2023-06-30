namespace FoodApp.DTO.Interfaces
{
    public interface IItemDTO
    {
        DateTime CreatedAt { get; set; }
        string Description { get; set; }
        int Id { get; set; }
        string ImageUrl { get; set; }
        int MenuId { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
        DateTime? UpdatedAt { get; set; }
    }
}