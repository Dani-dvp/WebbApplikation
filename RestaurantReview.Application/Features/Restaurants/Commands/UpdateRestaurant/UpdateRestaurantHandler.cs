using AutoMapper;
using RestaurantReview.Domain.IRepositories;
using RestaurantReview.Domain.Models;
using System;
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
                var oldRestaurant = await _restaurantRepository.GetRestaurantByName(updateRestaurantCommand.RestaurantName);

                var restaurant = new Restaurant()
                {
                    RestaurantID = new Guid(),
                    RestaurantLink = updateRestaurantCommand.RestaurantLink,
                    TempImage = updateRestaurantCommand.TempImage,
                    RestaurantName = updateRestaurantCommand.RestaurantName,
                    Description = updateRestaurantCommand.Description,
                    Categories = oldRestaurant.Categories,
                    Reviews = oldRestaurant.Reviews,
                    MapURL = oldRestaurant.MapURL,


                };
                await _restaurantRepository.UpdateAsync(restaurant);

                updateResponse = _mapper.Map<UpdateRestaurantRespone>(restaurant);
            }

            return updateResponse;

        }

    }
}
