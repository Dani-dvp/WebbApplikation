using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using RestaurantReview.Domain.AuthenticationModels;
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
        private readonly JwtSettings _jwtSettings;
        public CheckTokenIfValidHandler(IOptions<JwtSettings> jwtSettings)
        {
            _jwtSettings = jwtSettings.Value;
        }

        public bool ValidateCurrentToken(string token)
        {
            
            var mySecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));

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
