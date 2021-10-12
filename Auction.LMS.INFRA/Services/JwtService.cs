using Auction.LMS.CORE.Data;
using Auction.LMS.CORE.Repoisitory;
using Auction.LMS.CORE.Services;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;



namespace Auction.LMS.INFRA.Services
{
   public class JwtService : IJwtService
    {
        private readonly IJwtRepository jwtRepository;
        public JwtService(IJwtRepository jwtRepository)
        {
           this.jwtRepository  = jwtRepository;
        }

        public string Auth(Login login)
        {
            var result = jwtRepository.Auth(login);
            if (result == null)
            {
                return null;
            }
            else
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenKey = Encoding.ASCII.GetBytes("[My secret key, used to verify the token, it can be any string]");



                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, result.UserName),
                    new Claim(ClaimTypes.Role, result.Department.Name)

                }),
                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(new
                SymmetricSecurityKey(tokenKey),
                SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }

        }
    }
}
