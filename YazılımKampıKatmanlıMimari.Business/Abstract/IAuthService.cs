using YazılımKampıKatmanlıMimari.Core.Entities.Concrete;
using YazılımKampıKatmanlıMimari.Core.Utilities.Results;
using YazılımKampıKatmanlıMimari.Core.Utilities.Security.JWT;
using YazılımKampıKatmanlıMimari.Entities;

namespace YazılımKampıKatmanlıMimari.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
