using RestaurantReview.Application.Features.Restaurants.Queries.RestauranAvgRating;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Restaurants.Queries.RestaurantAvgRating
{
    public interface IRestaurantAvgRatingService
    {
        Task<double> RestaurantAvgRating(RestaurantAvgRatingCommand restaurantAvgRatingCommand);
    }
}
