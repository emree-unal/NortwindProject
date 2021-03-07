using System;
using System.Collections.Generic;
using System.Text;
using YazılımKampıKatmanlıMimari.Business.Abstract;
using YazılımKampıKatmanlıMimari.Core.Entities.Concrete;
using YazılımKampıKatmanlıMimari.DataAccess.Abstract;

namespace YazılımKampıKatmanlıMimari.Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }
    }
}
