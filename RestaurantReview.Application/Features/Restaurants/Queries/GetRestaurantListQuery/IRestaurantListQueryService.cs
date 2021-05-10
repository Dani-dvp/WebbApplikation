using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantListQuery
{
  public  interface IRestaurantListQueryService
    {
        Task<List<ResturantListQueryResponse>> GetRestaurantList();
    }
}
