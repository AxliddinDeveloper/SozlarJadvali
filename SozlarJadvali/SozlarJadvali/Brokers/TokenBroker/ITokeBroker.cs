using SozlarJadvali.Models.Admins;
using SozlarJadvali.Models.Tokens;
using SozlarJadvali.Models.Users;

namespace SozlarJadvali.Brokers.TokenBroker
{
    public interface ITokeBroker
    {
        UserToken GenerateJWTToken(Admin admin);

    }
}
