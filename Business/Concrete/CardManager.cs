using Business.Abstract;
using DataAccess.Absctract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CardManager : ICardService
    {
        ICardDal _cardDal;
        public CardManager(ICardDal cardDal)
        {
            _cardDal = cardDal;
        }
        public List<Card> GetCardsById(int id)
        {
            return _cardDal.GetAll(c=>c.CardId==id);
        }
    }
}
