using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOrderService
    {
        List<Order> GetAll();
        List<Order> GetAllByCustomerId(int customerId);
    }
}
