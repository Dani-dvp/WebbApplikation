using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantListQuery
{
    public interface IGetRestaurantListService
    {
        Task<List<GetRestaurantListResponse>> GetRestaurantList();
    }
}
