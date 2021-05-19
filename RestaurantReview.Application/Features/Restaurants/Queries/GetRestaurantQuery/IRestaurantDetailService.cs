using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantQuery
{
    public interface IRestaurantDetailService
    {
        Task<RestaurantDetailResponse> GetRestaurantByID(RestaurantDetailCommand getRestaurantCommand);
    }
}
