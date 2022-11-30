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
        public List<ComputerDetailDto> GetComputerDetail()
        {
            using (EcommContext context = new EcommContext())
            {
                var result = from p in context.Products
                             join c in context.Computers
                             on p.ProductId equals c.ProductId
                             select new ComputerDetailDto {ProductId=p.ProductId,
                                 ProductName=p.ProductName,
                                 Capacity=c.Capacity,
                                 ComputerId=c.ComputerId,
                                 ProductPrice=p.ProductPrice,
                                 Ram=c.Ram,
                                 Color=c.Color,
                                 Cpu=c.Cpu,
                                 Gpu=c.Gpu };
                return result.ToList();
            }
        }
    }
}
