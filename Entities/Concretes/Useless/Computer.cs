using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concretes
{
    public class Computer:IEntity
    {
        public int ComputerId { get; set; }
        public int ProductId { get; set; }
        public int Ram { get; set; }
        public int Capacity { get; set; }
        public string Color { get; set; }
        public string Gpu { get; set; }
        public string Cpu { get; set; }
    }
}
