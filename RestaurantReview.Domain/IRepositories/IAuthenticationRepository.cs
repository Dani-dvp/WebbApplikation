using RestaurantReview.Domain.AuthenticationModels;
using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Authentication
{
    public interface IAuthenticationRepository
    {
        Task<JwtSecurityToken> GenerateToken(ApplicationUser user);
    }
}
