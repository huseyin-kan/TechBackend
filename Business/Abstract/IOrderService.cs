using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<List<Order>> GetAll();
        IDataResult<List<Order>> GetAllByCustomerId(int customerId);
        IResult Add(Order order);
        IResult Update(Order order);
        IResult Delete(Order order);
    
    }
}
