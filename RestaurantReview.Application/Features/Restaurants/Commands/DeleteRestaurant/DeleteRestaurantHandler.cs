
using RestaurantReview.Domain.IRepositories;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Restaurants.Commands.DeleteRestaurant
{
    public class DeleteRestaurantHandler : IDeleteRestaurantService
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public DeleteRestaurantHandler(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }


        public async Task<string> DeleteRestaurant(DeleteRestaurantCommand deleteRestaurantCommand)
        {

            var RestaurantToBeDeleted = await _restaurantRepository.GetRestaurantByName(deleteRestaurantCommand.RestaurantName);
            await _restaurantRepository.DeleteAsync(RestaurantToBeDeleted);

            return RestaurantToBeDeleted.RestaurantName;
        }

    }
}
