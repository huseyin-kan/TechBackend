using Core.DataAccess;
using Entities.Concretes;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Absctract
{
    public interface IProductDal:IEntityRepository<Product> 
    {
        List<OrderDetailDto> GetOrderDetailDtos();
        

    }
}
