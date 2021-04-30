
using ResturantReview.Domain.IRepositories;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantReview.Application.Features.Restaurants.Commands.DeleteRestaurant
{
    public class DeleteRestaurantHandler
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public DeleteRestaurantHandler(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }


        public async Task<string> DeleteResturant(DeleteRestaurantCommand deleteResturantCommand)
        {

            var resturantToBeDeleted = await _restaurantRepository.GetResturantByName(deleteResturantCommand.RestaurantName);
          await  _restaurantRepository.DeleteAsync(resturantToBeDeleted);

            return resturantToBeDeleted.ResturantName;
        }

    }
}
