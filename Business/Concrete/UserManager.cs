using Business.Abstract;
using Core.Utilities.Results;
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

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult("Kayıt olundu");
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult("Kayıt silindi");
        }

        public IDataResult<User> GetUserById(int userId)
        {
            return new SuccessDataResult<User>(_userDal.Get(u=>u.UserId==userId));
        }

        public IDataResult<List<User>> GetUsers()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult("Kayıt Güncellendi");
        }
        public IDataResult<User> Login(string email, string password)
        {
            var user = _userDal.Get(u => u.UserEmail == email && u.UserPassword == password);
            if (user!=null)
            {
                return new SuccessDataResult<User>(user,"Giriş yapıldı");
            }
            return new ErrorDataResult<User>("Kullanıcı adı veya şifre yanlış");
        }
    }
}
