using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Absctract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OrderDetailManager : IOrderDetailService
    {
        IOrderDetailDal _orderDetailDal;
        public OrderDetailManager(IOrderDetailDal orderDetailDal)
        {
            _orderDetailDal = orderDetailDal;
        }
        public IResult Add(OrderDetail orderDetail)
        {
            _orderDetailDal.Add(orderDetail);
            return new SuccessResult("Sipariş detayı eklendi");
        }

        public IResult Delete(OrderDetail orderDetail)
        {
            _orderDetailDal.Delete(orderDetail);
            return new SuccessResult("Sipariş detayı silindi");
        }

        public IDataResult<List<OrderDetail>> GetByOrderId(int id)
        {
            var result = _orderDetailDal.GetAll(o=>o.OrderId==id);
            return new SuccessDataResult<List<OrderDetail>>(result);
        }
    }
}
