using AutoMapper;
using ResturantReview.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantReview.Application.Features.Restaurants.Commands.UpdateRestaurant
{
   public class UpdateRestaurantHandler
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IMapper _mapper;
        public UpdateRestaurantHandler(IMapper mapper, IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
            _mapper = mapper;
        }

        public async Task<UpdateRestaurantRespone> UpdateResturant(UpdateRestaurantCommand updateResturantCommand)
        {
           var resturantToBeUpdated = await _restaurantRepository.GetResturantByName(updateResturantCommand.RestaurantName);

            
            resturantToBeUpdated.ResturantName = updateResturantCommand.RestaurantName;
            resturantToBeUpdated.Category = updateResturantCommand.Category;
            resturantToBeUpdated.ResturantLink = updateResturantCommand.ResturantLink;
            resturantToBeUpdated.GoogleMapsPhoto = updateResturantCommand.GoogleMapsPhoto;
            resturantToBeUpdated.StreetPhoto = updateResturantCommand.StreetPhoto;

          await  _restaurantRepository.UpdateAsync(resturantToBeUpdated);

            var updateResturantResponse = _mapper.Map<UpdateRestaurantRespone>(resturantToBeUpdated);

            return updateResturantResponse;


        }

    }
}
