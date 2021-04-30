using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Restaurants.Commands.CreateRestaurant
{
    public interface ICreateRestaurantService
    {
        Task<CreateRestaurantResponse> CreateRestaurant(CreateRestaurantCommand createRestaurantCommand);
    }
}
