using System.Collections.Generic;
using System.Linq;
using domain.models;
using storage;

namespace repo
{
    public class CardRepo
    {
        WorkOutBuddyContext db;

        //Context passed through DI
        public CardRepo(WorkOutBuddyContext db_context)
        {
            db = db_context;
        }

        public IEnumerable<CardModel> GetAll()
        {
            return db.Cards;
        }

        public bool Post(CardModel card)
        {
            //Check is Cards already contains this card using Linq
            IEnumerable<CardModel> list = db.Cards.Where(x =>x.Name == card.Name);

            if(list.Count() < 1)
            {
                db.Cards.Add(card);
                db.SaveChanges();
                return true;
            }
            return false;
        }

    }
}