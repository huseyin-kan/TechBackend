using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class MousePad:IEntity
    {
        public int MousePadId { get; set; }
        public int ProductId { get; set; }
        public string Color { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }
}
