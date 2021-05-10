using AutoMapper;
using RestaurantReview.Domain.IRepositories;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Restaurants.Commands.UpdateRestaurant
{
    public class UpdateRestaurantHandler : IUpdateRestaurantService
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IMapper _mapper;
        public UpdateRestaurantHandler(IMapper mapper, IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
            _mapper = mapper;
        }

        public async Task<UpdateRestaurantRespone> UpdateRestaurant(UpdateRestaurantCommand updateRestaurantCommand)
        {
            var RestaurantToBeUpdated = await _restaurantRepository.GetRestaurantByName(updateRestaurantCommand.RestaurantName);


            RestaurantToBeUpdated.RestaurantName = updateRestaurantCommand.RestaurantName;
            RestaurantToBeUpdated.Category = updateRestaurantCommand.Category;
            RestaurantToBeUpdated.RestaurantLink = updateRestaurantCommand.RestaurantLink;
            RestaurantToBeUpdated.GoogleMapsPhoto = updateRestaurantCommand.GoogleMapsPhoto;
            RestaurantToBeUpdated.StreetPhoto = updateRestaurantCommand.StreetPhoto;

            await _restaurantRepository.UpdateAsync(RestaurantToBeUpdated);

            var updateRestaurantResponse = _mapper.Map<UpdateRestaurantRespone>(RestaurantToBeUpdated);

            return updateRestaurantResponse;


        }

    }
}
