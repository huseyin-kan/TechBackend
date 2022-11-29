using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concretes
{
    public class Gamepad:IEntity
    {
        public int GamepadId { get; set; }
        public int ProductId { get; set; }
        public string Color { get; set; }
        public string Relevance { get; set; }
    }
}
