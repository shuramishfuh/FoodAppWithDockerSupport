using FoodApp.DTO.Interfaces;

namespace FoodApp.Models.Models
{
    public class Tokens : ITokens
    {
        public string Access_Token { get; set; }
        public string Refresh_Token { get; set; }
    }
}
