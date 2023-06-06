using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ApiPerformans.Models.ApiModels;

//using WebApi.Models.ApiModels;
//using WebApi.Models.DataModels;
//using AccessToken = WebApi.Models.ApiModels.AccessToken;

namespace ApiPerformans.Helper.JwtToken
{
    public class JwtHelper
    {
        public JwtHelper()
        { }

        //public static AccessToken CreateToken(UserModel user, JwtSettings _jwtSetting)
        //{
        //    var claims = new[]
        //    {
        //        new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
        //        new Claim(ClaimTypes.Name, user.Username!),
        //        new Claim(ClaimTypes.Email, user.Email!),
        //        new Claim(ClaimTypes.Role, user.Role.ToString())
        //    };

        //    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSetting.SecurityKey!));
        //    var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        //    JwtSecurityToken jwtSecurityToken =
        //        new JwtSecurityToken(
        //            issuer: _jwtSetting.Issuer,
        //            audience: _jwtSetting.Audience,
        //            expires: DateTime.Now.AddMinutes(60),
        //            notBefore: DateTime.Now,
        //            claims: claims,
        //            signingCredentials: credentials
        //            );
        //    var token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
        //    var accessToken = new AccessToken
        //    {
        //        Token = token,
        //        Expiration = jwtSecurityToken.ValidTo
        //    };
        //    return accessToken;
        //}
    }
}