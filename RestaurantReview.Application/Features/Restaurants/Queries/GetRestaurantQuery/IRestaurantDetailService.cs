using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantQuery
{
    public interface IRestaurantDetailService
    {
        Task<RestaurantDetalResponse> GetRestaurantByID(RestaurantDetailCommand getRestaurantCommand);
    }
}
