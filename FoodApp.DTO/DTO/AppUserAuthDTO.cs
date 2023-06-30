using FoodApp.DTO.Interfaces;
using FoodApp.Models.Models;

namespace FoodApp.DTO.DTO
{
    public class AppUserAuthDTO : IAppUserAuthDTO
    {
        public int Id { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string? RefreshToken { get; set; }
        public bool RefreshTokenIsActive { get; set; }

        public static explicit operator AppUserAuthDTO(AppUser appUser)
        {
            return new AppUserAuthDTO
            {
                Id = appUser.Id,
                Role = appUser.Role,
                Password = appUser.PasswordHash,
                UserName = appUser.UserName,
                RefreshToken = appUser.RefreshToken,
                RefreshTokenIsActive = appUser.RefreshTokenIsActive
            };


        }
    }
}

