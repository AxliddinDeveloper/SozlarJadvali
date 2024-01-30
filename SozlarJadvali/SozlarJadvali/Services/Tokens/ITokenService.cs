using SozlarJadvali.Models.Admins;
using SozlarJadvali.Models.Tokens;

namespace SozlarJadvali.Services.Tokens
{
    public interface ITokenService
    {
        UserToken AddToken(Admin admin);
    }
}
