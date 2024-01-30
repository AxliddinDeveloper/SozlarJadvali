using SozlarJadvali.Brokers.TokenBroker;
using SozlarJadvali.Models.Admins;
using SozlarJadvali.Models.Tokens;

namespace SozlarJadvali.Services.Tokens
{
    public class TokenService : ITokenService
    {
        private readonly ITokeBroker tokenBroker;

        public TokenService(ITokeBroker tokenBroker)
        {
            this.tokenBroker = tokenBroker;
        }

        public UserToken AddToken(Admin admin) =>
             this.tokenBroker.GenerateJWTToken(admin);
    }
}
