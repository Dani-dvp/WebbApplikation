using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Authentication.Queries.GetUserByUsername
{
    public interface IGetUserByUsernameService
    {
        Task<GetUserByUsernameResponse> GetUserByUsername(string username);
    }
}
