using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Order:IEntity
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderTime { get; set; }
        public bool IsDelivered { get; set; }
        public int OrderNumber { get; set; }
        public decimal  OrderTotal { get; set; }
    }
}
