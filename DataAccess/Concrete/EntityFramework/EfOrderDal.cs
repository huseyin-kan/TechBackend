using Core.EntityFramework;
using DataAccess.Absctract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal: EfEntityRepositoryBase<Order, EcommContext>, IOrderDal
    {
    }
}
