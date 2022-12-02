using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        public List<User> GetUsers();
        public User GetUserById(int userId);
    }
}
