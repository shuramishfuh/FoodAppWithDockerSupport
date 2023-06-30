using FoodApp.Models.Interfaces;
using FoodApp.Models.Models;
using FoodApp.ORM;
using FoodApp.RestAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodApp.RestAPI.Repository
{
    public class AddressServiceRepository : IAddressServiceRepository
    {
        private readonly FoodAppContext _db;
        public AddressServiceRepository(FoodAppContext db)
        {
            _db = db;
        }
        public bool AddAddress(Address addr)
        {
            try
            {
                var user = _db.AppUsers.FirstOrDefault(a => a.Id == addr.UserId);
                if (user != null)
                {
                    _db.Addresses.Add(addr);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteAddressWithId(int id)
        {
            try
            {
                _db.Addresses.Where(a => a.Id == id).ExecuteDelete();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public IAddress GetAddressWithID(int id)
        {
            return _db.Addresses.FirstOrDefault(a => a.Id == id);
        }

        public IAddress UpdateAddress(IAddress address)
        {
            var addre = (Address)address;
            _db.Addresses.Add(addre);
            return addre;
        }

        public int SaveCommit()
        {
            return _db.SaveChanges();
        }
    }
}
