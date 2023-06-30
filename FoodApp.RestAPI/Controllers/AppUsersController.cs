using FoodApp.DTO.DTO;
using FoodApp.Models.Models;
using FoodApp.RestAPI.Jwt.Interfaces;
using FoodApp.RestAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FoodApp.RestAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AppUsersController : Controller
    {
        private readonly IJWTManagerRepository jWTManager;
        private readonly IUserServiceRepository userServiceRepository;

        public AppUsersController(IJWTManagerRepository jWTManager, IUserServiceRepository userServiceRepository)
        {
            this.jWTManager = jWTManager;
            this.userServiceRepository = userServiceRepository;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("CreateUser")]
        public async Task<IActionResult> CreateUser([FromBody] CreatUserDTO user)
        {
            if (user == null) { return BadRequest(); }
            var _user = userServiceRepository.CreatUser(user);
            userServiceRepository.SaveCommit();
            return Ok(_user);

        }

        [AllowAnonymous]
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> AuthenticateAsync(AppUserAuthDTO usersdata)
        {
            var _user = userServiceRepository.FindAppuserhWithUserName(usersdata.UserName);
            if (_user == null) { return BadRequest(); }
            var validUser = await userServiceRepository.IsValidUserAsync(usersdata, _user.PasswordHash);

            if (!validUser)
            {
                return Unauthorized("Invalid user!");
            }

            var token = jWTManager.GenerateToken(usersdata.UserName, usersdata.Role);

            if (token == null)
            {
                return Unauthorized("Invalid Attempt!");
            }

            userServiceRepository.AddUserRefreshTokens(_user, token);
            userServiceRepository.SaveCommit();
            return Ok(token);
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("refresh")]
        public IActionResult Refresh(Tokens token)
        {
            if (token == null) { return BadRequest(); }
            var principal = jWTManager.GetPrincipalFromExpiredToken(token.Access_Token);
            var username = principal.Identity?.Name;

            //retrieve the saved refresh token from database
            var user = userServiceRepository.GetSavedRefreshTokensWithUser(username, token.Refresh_Token);

            if (user.RefreshToken != token.Refresh_Token)
            {
                return Unauthorized("Invalid attempt!");
            }

            var newJwtToken = jWTManager.GenerateRefreshToken(user.UserName, user.Role);

            if (newJwtToken == null)
            {
                return Unauthorized("Invalid attempt!");
            }

            userServiceRepository.AddUserRefreshTokens(user, newJwtToken);
            userServiceRepository.SaveCommit();

            return Ok(newJwtToken);
        }

        [HttpDelete, Route("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var result = userServiceRepository.DeleteWIthID(id);
            if (result == 0) { return BadRequest(); }

            userServiceRepository.SaveCommit();
            return NoContent();
        }

        [HttpGet, Route("GetUserById")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var result = userServiceRepository.FindAppuserAuthWithId(id);
            if (result is null) { return BadRequest(); }
            return Ok(result);
        }

        [HttpGet, Route("GetUserByName")]
        public async Task<IActionResult> GetUserByName(string name)
        {
            var result = userServiceRepository.FindAppuserhWithUserName(name);
            if (result is null) { return BadRequest(); }
            return Ok(result);
        }



    }
}
