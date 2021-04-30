using AutoMapper;
using ResturantReview.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantReview.Application.Features.Restaurants.Queries.GetRestaurantQuery
{
    public class RestaurantDetailQueryHandler
    {
        //Innehåller kod för metoder, Hittar detta genom att kalla på databasen genom Repository

        //Får inte returnera en vanlig "Model" Måste Returner en ResponsTyp med innehållet man vill visa.
        private readonly IMapper _mapper;
       
        private readonly IRestaurantRepository _restaurantRepository;


        public RestaurantDetailQueryHandler(IMapper mapper , IRestaurantRepository restaurantRepository)
        {
            _mapper = mapper;
            _restaurantRepository = restaurantRepository;

        }

        public async Task<RestaurantDetalResponse> GetResturantByID(RestaurantDetailCommand getResturantCommand)
        {
         var resturant = await _restaurantRepository.GetByIdAsync(getResturantCommand.RestaurantID);

         var resturantResponse = _mapper.Map<RestaurantDetalResponse>(resturant);

            return resturantResponse;


        }





    }
}
