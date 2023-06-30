using FoodApp.DTO.DTO;
using FoodApp.DTO.Interfaces;
using FoodApp.Models.Interfaces;
using FoodApp.Models.Models;
using FoodApp.ORM;
using FoodApp.RestAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodApp.RestAPI.Repository
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserServiceRepository"/> class.
    /// </summary>
    /// <param name="db">The <see cref="FoodAppContext"/> instance to be used for accessing the data store.</param>
    public class UserServiceRepository : IUserServiceRepository
    {
        private readonly FoodAppContext _db;

        public UserServiceRepository(FoodAppContext db)
        {
            _db = db;
        }

        public IAppUser CreatUser(CreatUserDTO user)
        {
            AppUser appUser = (AppUser)user;
            appUser.PasswordHash = BCrypt.Net.BCrypt.HashPassword(appUser.PasswordHash);
            _db.AppUsers.AddAsync(appUser);
            return appUser;
        }

        public void AddUserRefreshTokens(IAppUser _user, ITokens token)
        {
            if (_user != null)
            {
                _user.RefreshToken = token.Refresh_Token;

            }
        }

        public void DeleteUserRefreshTokens(string username, string refreshToken)
        {
            var item = _db.AppUsers.FirstOrDefault(x => x.UserName == username && x.RefreshToken == refreshToken);
            if (item != null)
            {
                item.RefreshToken = null;
                SaveCommit();
            }
        }

        public IAppUser? GetSavedRefreshTokensWithUser(string username, string refreshToken)
        {
            return _db.AppUsers.FirstOrDefault(x => x.UserName == username && x.RefreshToken == refreshToken);

        }

        public async Task<bool> IsValidUserAsync(IAppUserAuthDTO users, string hashPassWord)
        {
            return BCrypt.Net.BCrypt.Verify(users.Password, hashPassWord);

        }

        public IAppUser FindAppuserAuthWithId(int id)
        {
            var user = _db.AppUsers
                    .Where(x => x.Id == id);
            return (AppUser)user;
        }

        public IAppUser? FindAppuserhWithUserName(string userName)
        {
            return _db.AppUsers.FirstOrDefault(o => o.UserName == userName);

        }

        public int SaveCommit()
        {
            return _db.SaveChanges();
        }

        public IAppUser UpdateUser(IAppUser appUser)
        {
            var user = (AppUser)appUser;
            var a = _db.AppUsers.Update(user);
            SaveCommit();
            return user;
        }

        public int DeleteWIthID(int id)
        {
            return _db.AppUsers
                  .Where(x => x.Id == id)
                  .ExecuteDelete();
        }
    }
}
