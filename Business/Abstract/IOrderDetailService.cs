using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOrderDetailService
    {
        IResult Add(OrderDetail orderDetail);
        IResult Delete(OrderDetail orderDetail);
        IDataResult<List<OrderDetail>> GetByOrderId(int id);
    }
}
