using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICardService
    {
        List<Card> GetCardsById(int id);
    }
}
