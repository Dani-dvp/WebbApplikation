using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantByNameQuery
{
    public interface IGetRestaurantByNameService
    {
        Task<GetRestaurantByNameResponse> GetRestaurantByName(GetRestaurantByNameCommand getRestaurantByNameCommand);
    }
}
