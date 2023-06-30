

using FoodApp.DTO.Interfaces;
using FoodApp.Models.Models;

namespace FoodApp.DTO.DTO;

public partial class AddressDTO : IAddressDTO
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Street { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string ZipCode { get; set; } = null!;

    public string Country { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public static implicit operator Address(AddressDTO addressDTO)
    {
        return new Address
        {
            UserId = addressDTO.UserId,
            City = addressDTO.City,
            Street = addressDTO.Street,
            State = addressDTO.State,
            ZipCode = addressDTO.ZipCode,
            Country = addressDTO.Country,
            CreatedAt = addressDTO.CreatedAt,
            UpdatedAt = addressDTO.UpdatedAt
        };
    }



}
