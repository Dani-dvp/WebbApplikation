using AutoMapper;
using RestaurantReview.Domain.IRepositories;
using RestaurantReview.Domain.Models;
using System.Collections.Generic;
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
            var updateResponse = new UpdateRestaurantRespone();


            var validator = new UpdateRestaurantValidator(_restaurantRepository);
            var validationResult = await validator.ValidateAsync(updateRestaurantCommand);


            if (validationResult.Errors.Count > 0)
            {
                updateResponse.Success = false;
                updateResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    updateResponse.ValidationErrors.Add(error.ErrorMessage);
                }

            }

            if (updateResponse.Success)
            {
                var restaurant = new Restaurant()
                {
                    RestaurantLink = updateRestaurantCommand.RestaurantLink,
                    TempImage = updateRestaurantCommand.TempImage,
                    RestaurantName = updateRestaurantCommand.RestaurantName,
                    MapURL = updateRestaurantCommand.MapURL,
                    Description = updateRestaurantCommand.Description,

                };
                await _restaurantRepository.UpdateAsync(restaurant);

                updateResponse = _mapper.Map<UpdateRestaurantRespone>(restaurant);
            }

            return updateResponse;

        }

    }
}
