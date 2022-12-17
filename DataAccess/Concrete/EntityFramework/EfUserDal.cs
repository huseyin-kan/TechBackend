using Core.EntityFramework;
using DataAccess.Absctract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, EcommContext>, IUserDal
    {
        public void updateUser(User user)
        {
            using (EcommContext context= new EcommContext())
            {

                context.Users.Add(user);
                context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
