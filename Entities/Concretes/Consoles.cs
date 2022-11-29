using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concretes
{
    public class Consoles:IEntity
    {
        public int ConsoleId { get; set; }
        public int ProductId { get; set; }
        public string Color { get; set; }
        public int GamepadNumber { get; set; }
        public int Capacity { get; set; }
    }
}
