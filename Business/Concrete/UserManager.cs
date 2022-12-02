using Business.Abstract;
using DataAccess.Absctract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public User GetUserById(int userId)
        {
            return _userDal.Get(u=>u.UserId==userId);
        }

        public List<User> GetUsers()
        {
            return _userDal.GetAll();
        }
    }
}
