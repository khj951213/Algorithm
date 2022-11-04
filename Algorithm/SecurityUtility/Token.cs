using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace SecurityUtility
{
    public class Token
    {
        public static void TokenGenerator()
        {

        }

        public static string SampletokenGenerator(int id, string jwtToken, int expireDays)
        {
            byte[] key = Encoding.ASCII.GetBytes(jwtToken);
            var securityKey = new SymmetricSecurityKey(key);
            var subject = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.PrimarySid, id.ToString()),
            });

            //subject.AddClaims(permissionStrList.Select(p => new Claim(p, "1")));

            var descriptor = new SecurityTokenDescriptor
            {
                Subject = subject,
                Expires = DateTime.Now.AddDays(expireDays),
                SigningCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256)
            };
            var handler = new JwtSecurityTokenHandler();
            var token = handler.CreateJwtSecurityToken(descriptor);
            return handler.WriteToken(token);
        }
    }
}
