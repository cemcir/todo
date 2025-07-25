using Core.Entities.Concrete;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    public static class TokenService
    {
        public static string secretKey="fullstackdevelopercemcirmuhammedenescemcir";
        public static string issuer= "https://localhost:44346"; // domain ismi
        public static string audiance = "https://localhost:44346";

        public static string GenerateToken(int userId,List<Role> roles=null) // rol bazlı jwt üretir
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            var credentials = new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256); // sha 256 algoritmasıyla oluşturduk

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject=new ClaimsIdentity(new[]
                {
                    new Claim("userId",userId.ToString())
                }),
                Expires=DateTime.Now.AddMinutes(120),
                Issuer=issuer,
                Audience=audiance,
                SigningCredentials=credentials
            };

            if (roles != null)
            {
                foreach (var role in roles)
                {
                    tokenDescriptor.Subject.AddClaim(new Claim(ClaimTypes.Role, role.RoleName));
                }
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

    }
}
