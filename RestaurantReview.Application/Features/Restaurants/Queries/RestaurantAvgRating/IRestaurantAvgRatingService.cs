using RestaurantReview.Application.Features.Restaurants.Queries.RestauranAvgRating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Restaurants.Queries.RestaurantAvgRating
{
  public interface IRestaurantAvgRatingService
    {
        Task<double> RestaurantAvgRating(RestaurantAvgRatingCommand restaurantAvgRatingCommand);
    }
}
