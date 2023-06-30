using FoodApp.DTO.Interfaces;
using System.Security.Claims;

namespace FoodApp.RestAPI.Jwt.Interfaces
{
    public interface IJWTManagerRepository
    {
        ITokens GenerateToken(string userName, string userRole);
        ITokens GenerateRefreshToken(string userName, string userRole);
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
