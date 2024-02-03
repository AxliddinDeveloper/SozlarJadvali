using Microsoft.IdentityModel.Tokens;
using SozlarJadvali.Models.Admins;
using SozlarJadvali.Models.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SozlarJadvali.Brokers.TokenBroker
{
    public class TokenBroker : ITokeBroker
    {
        public UserToken GenerateJWTToken(Admin admin)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email,admin.Email),
                new Claim(ClaimTypes.Role,"Admin"),
            };

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("48sd4v89d4v941-A984sv98d4v9805E-7045C855BA22r4g98s4g9es8sdg8d49g"));

            var signingCred = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512);

            var securityToken = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: signingCred
            );

            string tokenString = new JwtSecurityTokenHandler().WriteToken(securityToken);

            return new UserToken
            {
                Token = tokenString,
            };
        }
    }
}