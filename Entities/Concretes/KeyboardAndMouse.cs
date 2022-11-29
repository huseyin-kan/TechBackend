using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concretes
{
    public class KeyboardAndMouse:IEntity
    {
        public int KmId { get; set; }
        public int ProductId { get; set; }
        public string Color { get; set; }
    }
}
