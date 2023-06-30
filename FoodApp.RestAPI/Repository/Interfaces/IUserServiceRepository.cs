using FoodApp.DTO.DTO;
using FoodApp.DTO.Interfaces;
using FoodApp.Models.Interfaces;

namespace FoodApp.RestAPI.Repository.Interfaces
{
    public interface IUserServiceRepository
    {
        public IAppUser CreatUser(CreatUserDTO user);
        public Task<bool> IsValidUserAsync(IAppUserAuthDTO users, string hashPassWord);

        public void AddUserRefreshTokens(IAppUser _user, ITokens token);

        public IAppUser GetSavedRefreshTokensWithUser(string username, string refreshtoken);

        void DeleteUserRefreshTokens(string username, string refreshToken);

        public IAppUser FindAppuserhWithUserName(string userName);

        public IAppUser FindAppuserAuthWithId(int id);

        public int SaveCommit();

        public IAppUser UpdateUser(IAppUser appUser);

        public int DeleteWIthID(int id);
    }
}
