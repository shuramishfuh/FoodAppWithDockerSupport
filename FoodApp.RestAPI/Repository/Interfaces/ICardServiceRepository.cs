using FoodApp.DTO.Interfaces;
using FoodApp.Models.Interfaces;

namespace FoodApp.RestAPI.Repository.Interfaces
{
    public interface ICardServiceRepository
    {
        public ICard? GetCardById(int id);
        public IEnumerable<ICardDTO>? GetAllCardsWithUserId(int idUserId);
        public bool DeleteCard(int id);
        public bool UpdateCard(ICardDTO card);
        public bool CreateCard(ICardDTO card);
        public int SaveCommit();
    }
}
