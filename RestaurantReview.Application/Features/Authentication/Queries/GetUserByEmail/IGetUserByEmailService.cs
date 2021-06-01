using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Authentication.Queries.GetUserByEmail
{
    public interface IGetUserByEmailService
    {
        Task<GetUserByEmailResponse> GetUserByEmail(string email);
    }
}
