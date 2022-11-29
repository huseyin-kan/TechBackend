using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concretes
{
    public class Headphone:IEntity
    {
        public int HeadphonesId { get; set; }
        public int ProductId { get; set; }
        public bool IsWireless { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public bool IsGaming { get; set; }
    }
}
