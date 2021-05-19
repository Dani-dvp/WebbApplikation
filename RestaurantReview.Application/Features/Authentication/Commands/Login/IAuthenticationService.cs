using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Authentication.Commands.Login
{
    public interface IAuthenticationService
    {
        Task<AuthenticationResponse> AuthenticateAsync(AuthenticationCommand request);
    }
}
