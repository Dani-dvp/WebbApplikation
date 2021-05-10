using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Authentication.Commands.Register
{
    public interface IRegistrationService
    {
        Task<RegistrationResponse> RegisterAsync(RegistrationCommand request);
    }
}
