using FoodApp.DTO.Interfaces;
using FoodApp.Models.Models;

namespace FoodApp.DTO.DTO
{
    public class CreatUserDTO : ICreatUserDTO
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }

        public static explicit operator AppUser(CreatUserDTO creatUserDTO)
        {
            return new AppUser
            {
                Email = creatUserDTO.Email,
                UserName = creatUserDTO.UserName,
                Role = creatUserDTO.Role,
                PasswordHash = creatUserDTO.PasswordHash,
                PhoneNumber = creatUserDTO.PhoneNumber

            };
        }
    }
}
