using Core.DataAccess;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Absctract
{
    public interface IUserDal:IEntityRepository<User>
    {
    }
}
