using Core.DataAccess;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Absctract
{
    interface IOrderDetailDal:IEntityRepository<OrderDetailDto>
    {
    }
}
