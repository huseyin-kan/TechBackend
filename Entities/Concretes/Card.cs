using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concretes
{
    public class Card:IEntity
    {
        public int CardId { get; set; }
        public int CustomerId { get; set; }
        public int CardNumber { get; set; }
        public DateTime CardValidDate { get; set; }
        public string CardSecurityName { get; set; }
    }
}
