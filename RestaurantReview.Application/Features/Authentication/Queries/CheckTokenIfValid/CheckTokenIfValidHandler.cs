using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Authentication.Queries.CheckTokenIfValid
{
    public class CheckTokenIfValidHandler : ICheckIfTokenIsValidService
	{
        public bool ValidateCurrentToken(string token)
        {
            var mySecret = "asdv2%!#%4^&%&^%&^hjsdf6gf3%";
            var mySecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(mySecret));

            var myIssuer = "RestaurantReviewIdentity";
            var myAudience = "RestaurantReviewIdentityUser";

            var tokenHandler = new JwtSecurityTokenHandler();
            try
            {
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidIssuer = myIssuer,
                    ValidAudience = myAudience,
                    IssuerSigningKey = mySecurityKey
                }, out SecurityToken validatedToken);
            }
            catch
            {
                return false;
            }
            return true;
        }

    }
}
