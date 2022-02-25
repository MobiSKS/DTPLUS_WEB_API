using HPCL.Infrastructure.Extension;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using static HPCL.Infrastructure.CommonClass.StatusMessage;
using Microsoft.OpenApi.Extensions;
using HPCL.Infrastructure.CommonClass;

namespace HPCL.Infrastructure.TokenManager
{

    public class TokenManager
    {


        //private static string Secret = Guid.NewGuid().ToString();
        public static string Secret = string.Empty;
        public static string GenerateToken(string Useragent, string Userip)
        {
            byte[] key = Convert.FromBase64String(Secret);
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(key);
            SecurityTokenDescriptor descriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                      new Claim(ClaimTypes.Name, Useragent)
                }),
                Expires = DateTime.UtcNow.AddMinutes(300),
                Issuer = Userip,
                Audience = Useragent,
                SigningCredentials = new SigningCredentials(securityKey,
                SecurityAlgorithms.HmacSha256Signature)
            };

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            JwtSecurityToken token = handler.CreateJwtSecurityToken(descriptor);
            return handler.WriteToken(token);
        }
        public static ClaimsPrincipal GetPrincipal(string token, string Useragent, string Userip, string UserId)
        {
            try
            {
                JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
                JwtSecurityToken jwtToken = (JwtSecurityToken)tokenHandler.ReadToken(token);
                if (jwtToken == null)
                    return null;
                byte[] key = Convert.FromBase64String(Secret);
                TokenValidationParameters parameters = new TokenValidationParameters()
                {
                    NameClaimType = UserId,
                    RequireExpirationTime = true,
                    ValidateIssuer = true,
                    ValidateIssuerSigningKey = true,
                    ValidateAudience = true,
                    ValidIssuer = Userip,
                    ValidAudience = Useragent,
                    IssuerSigningKey = new SymmetricSecurityKey(key)
                };


                ClaimsPrincipal principal = tokenHandler.ValidateToken(token, parameters, out SecurityToken securityToken);
                return principal;


            }
            catch
            {
                return null;
            }
        }
        public static string ValidateToken(string token, string Useragent, string Userip, string UserId)
        {
            ClaimsPrincipal principal = GetPrincipal(token, Useragent, Userip, UserId);
            if (principal == null)
                return null;
            ClaimsIdentity identity;
            try
            {
                identity = (ClaimsIdentity)principal.Identity;
            }
            catch (NullReferenceException)
            {
                return null;
            }
            Claim usernameClaim = identity.FindFirst(ClaimTypes.Name);
            string username = usernameClaim.Value;
            return username;
        }


    }
}
