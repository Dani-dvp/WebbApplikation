using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Restaurants.Queries.GetThreeRandomRestaurants
{
    public interface IGetThreeRandomRestaurantsService
    {
        Task<List<GetThreeRandomRestaurantsResponse>> GetThreeRandomResturants();
    }
}
