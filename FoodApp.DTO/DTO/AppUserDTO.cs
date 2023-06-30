
using FoodApp.DTO.Interfaces;
using FoodApp.Models.Models;

namespace FoodApp.DTO.DTO;

public partial class AppUserDTO : IAppUserDTO
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public bool EmailVerified { get; set; }

    public bool PhoneVerified { get; set; }

    public DateTime CreatedAt { get; set; }


    public static explicit operator AppUserDTO(AppUser dto)
    {
        return new AppUserDTO
        {
            Id = dto.Id,
            Name = dto.UserName,
            Email = dto.Email,
            PasswordHash = dto.PasswordHash,
            PhoneNumber = dto.PhoneNumber,
            EmailVerified = dto.EmailVerified,
            PhoneVerified = dto.PhoneVerified
        };
    }


}
