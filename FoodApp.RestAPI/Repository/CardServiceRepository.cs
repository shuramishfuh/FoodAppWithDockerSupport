using FoodApp.DTO.Interfaces;
using FoodApp.Models.Interfaces;
using FoodApp.Models.Models;
using FoodApp.ORM;
using FoodApp.RestAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodApp.RestAPI.Repository
{
    public class CardServiceRepository : ICardServiceRepository
    {
        private readonly FoodAppContext _db;

        public CardServiceRepository(FoodAppContext db)
        {
            _db = db;
        }
        // TODO: how to best store the cards
        public bool CreateCard(ICardDTO card)
        {

            try
            {
                Card _ = (Card)card;
                _db.Cards.Add(_);
                SaveCommit();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteCard(int id)
        {
            try
            {
                _db.Cards
                    .Where(x => x.Id == id)
                    .ExecuteDelete();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public IEnumerable<ICardDTO>? GetAllCardsWithUserId(int UserId)
        {
            return _db.Cards
               .Where(x => x.UserId == UserId)
               .Select(x => (ICardDTO)x)
               .ToList();
        }

        public ICard? GetCardById(int id)
        {
            return _db.Cards
                .Where(c => c.Id == id)
                .FirstOrDefault();
        }

        public int SaveCommit()
        {
            return _db.SaveChanges();
        }

        public bool UpdateCard(ICardDTO cardDto)
        {
            var card = GetCardById(cardDto.Id);
            if (card != null)
            {

                card.NameOnCard = cardDto.NameOnCard;
                card.CardNumber = cardDto.CardNumber;
                card.Cvv = cardDto.Cvv;
                card.ExpirationDate = cardDto.ExpirationDate;

                SaveCommit();

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
