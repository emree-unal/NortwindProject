using System;
using System.Collections.Generic;
using System.Text;
using YazılımKampıKatmanlıMimari.Core.DataAcess;
using YazılımKampıKatmanlıMimari.Core.Entities.Concrete;

namespace YazılımKampıKatmanlıMimari.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
