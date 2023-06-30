using FoodApp.Models.Interfaces;
using FoodApp.Models.Models;

namespace FoodApp.RestAPI.Repository.Interfaces
{
    public interface IAddressServiceRepository
    {
        public IAddress GetAddressWithID(int id);
        public bool AddAddress(Address address);
        public bool DeleteAddressWithId(int id);
        public IAddress UpdateAddress(IAddress address);
        public int SaveCommit();

    }
}
