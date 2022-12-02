using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Mouse:IEntity
    {
        public int MouseId { get; set; }
        public int ProductId { get; set; }
        public string Color { get; set; }
        public bool IsWireless { get; set; }
        public bool IsGaming { get; set; }
    }
}
