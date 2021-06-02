using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Restaurants.Queries.RestaurantReviewCountQuery
{
    public interface IRestaurantReviewCountService
    {
        Task<int> RestaurantReviewsCount(RestaurantReviewCountCommand restaurantReviewCommand);

    }
}
