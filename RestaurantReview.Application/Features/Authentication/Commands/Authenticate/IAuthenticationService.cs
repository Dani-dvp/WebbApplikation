using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Authentication.Commands.Authenticate
{
    public interface IAuthenticationService
    {
        Task<AuthenticationResponse> AuthenticateAsync(AuthenticationCommand request);
    }
}
