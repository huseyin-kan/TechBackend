using Core.EntityFramework;
using DataAccess.Absctract;
using Entities.Concretes;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, EcommContext>, IProductDal
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
                                 OrderDetailsId = o.OrderDetailsId,
                                 Quantity = o.Quantity,
                                 ProductPrice = p.ProductPrice,
                                 ProductDescription = p.ProductDescription,
                                 UnitsInStock = p.UnitsInStock,
                                 ProductBrand = p.ProductBrand,
                                 ProductColor=p.ProductColor
                             };

                return result.ToList();
            }
        }

    }
}
