namespace FoodApp.DTO.Interfaces
{
    public interface IAddressDTO
    {
        string City { get; set; }
        string Country { get; set; }
        DateTime CreatedAt { get; set; }
        int Id { get; set; }
        string State { get; set; }
        string Street { get; set; }
        DateTime? UpdatedAt { get; set; }
        int UserId { get; set; }
        string ZipCode { get; set; }
    }
}