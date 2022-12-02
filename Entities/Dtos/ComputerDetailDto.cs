using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class ComputerDetailDto:IDto
    {
        public int ComputerId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Capacity { get; set; }
        public decimal ProductPrice { get; set; }
        public int Ram { get; set; }
        public string Gpu { get; set; }
        public string Cpu { get; set; }
        public string Color { get; set; }
    }
}
