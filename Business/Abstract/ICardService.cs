using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICardService
    {
        IDataResult<List<Card>> GetCardsById(int id);
        IResult Add(Card card);
        IResult Update(Card card);
        IResult Delete(Card card);
    }
}
