using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Absctract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public IResult Add(Order order)
        {
            _orderDal.Add(order);
            return new SuccessResult("Siparişiniz alındı");
            throw new NotImplementedException();
        }

        public IResult Delete(Order order)
        {
            _orderDal.Delete(order);
            return new SuccessResult("Siparişiniz silindi");

        }

        public IDataResult<List<Order>> GetAll()
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll());
        }

        public IDataResult<List<Order>> GetAllByCustomerId(int customerId)
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(o=>o.CustomerId==customerId));
        }

        public IResult Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
