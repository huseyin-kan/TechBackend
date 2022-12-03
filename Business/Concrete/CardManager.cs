using Business.Abstract;
using Core.Utilities.Results;
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

        public IResult Add(Card card)
        {
            _cardDal.Add(card);
            return new SuccessResult("Kartınız eklendi");
            throw new NotImplementedException();
        }

        public IResult Delete(Card card)
        {
            _cardDal.Delete(card);
            return new SuccessResult("Kart silindi");
            throw new NotImplementedException();
        }

        public IDataResult<List<Card>> GetCardsById(int id)
        {
            return new SuccessDataResult<List<Card>>(_cardDal.GetAll(c=>c.CardId==id));
        }

        public IResult Update(Card card)
        {
            _cardDal.Update(card);
            return new SuccessResult("Kart güncellendi");
            throw new NotImplementedException();
        }
    }
}
