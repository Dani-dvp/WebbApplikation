using RestaurantReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Restaurants.Queries.RestaurantListQuery.RestaurantReviews
{
   public interface IRestaurantReviewsService
    {
        Task<RestaurantReviewsResponse> GetRestaurantReviews(RestaurantReviewsCommand restaurantReviewsCommand);
    }
}
