using Core.EntityFramework;
using DataAccess.Absctract;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    class EfOrderDetailDal: EfEntityRepositoryBase<OrderDetailDto, EcommContext>, IOrderDetailDal
    {
        public List<OrderDetailDto> GetOrderDetailDtos()
        {
            using (EcommContext context = new EcommContext())
            {
                var result = from p in context.Products
                             join o in context.OrderDetails
                             on p.ProductId equals o.ProductId
                             select new OrderDetailDto
                             {
                                 OrderId = o.OrderId,
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 OrderDetailsId = o.OrderDetailId,
                                 Quantity = o.Quantity,
                                 ProductPrice = p.ProductPrice,
                                 ProductDescription = p.ProductDescription,
                                 UnitsInStock = p.UnitsInStock,
                                 ProductBrand=p.ProductBrand
                             };
                return result.ToList();
            }
        }
    }
}
