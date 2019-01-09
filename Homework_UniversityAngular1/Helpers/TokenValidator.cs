using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.WebApp.Helpers
{
    public class GetToken
    {
        public string token { get; set; }
    }
    public class TokenValidator
    {
        public string role;
        public string getRole(string token)
        {
            string secret = "AIzaSyBfVy9uYVKSU9ojYZ4oCV-6vgKrOhomvCU";
            var key = Encoding.ASCII.GetBytes(secret);
            var handler = new JwtSecurityTokenHandler();
            var tokenSecure = handler.ReadToken(token) as SecurityToken;
            var validations = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false,
                //ValidateLifetime = true
            };
            var claims = handler.ValidateToken(token, validations, out tokenSecure);
            //var payload = claims.Claims;
            foreach(var t in claims.Claims)
            {
                if (t.Type.Contains("role"))
                    role =  t.Value;
            }
            return role;
        }
    }
}
