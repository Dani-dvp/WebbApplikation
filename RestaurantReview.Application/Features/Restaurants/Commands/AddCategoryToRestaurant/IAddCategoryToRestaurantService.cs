using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Restaurants.Commands.AddCategoryToRestaurant
{
    public interface IAddCategoryToRestaurantService
    {
        Task<AddCategoryToRestaurantResponse> AddCategoryToRestaurant(AddCategoryToRestaurantCommand addCategoryToRestaurantCommand);
    }
}
