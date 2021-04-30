using AutoMapper;
using ResturantReview.Domain.IRepositories;
using ResturantReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ResturantReview.Application.Features.Restaurants.Commands.CreateRestaurant
{
    public class CreateRestaurantHandler : ICreateRestaurantService
    {
        //Innehåller kod för metoder, sparar detta sedan genom att kalla på Repository för sin klass

        //Får inte returnera en vanlig "Model" Måste Returner en ResponsTyp med innehållet man vill visa.
        private readonly IMapper _mapper;
        private readonly IRestaurantRepository _restaurantRepository;

       
        public CreateRestaurantHandler(IMapper mapper , IRestaurantRepository restaurantRepository)
        {
            _mapper = mapper;
            _restaurantRepository = restaurantRepository;
        }

        public async Task<CreateRestaurantResponse>  CreateRestaurant(CreateRestaurantCommand createResturantCommand )
        {
            var resturant = new Resturant()
            {
                ResturantName = createResturantCommand.RestaurantName,
                Category = createResturantCommand.Category,
                StreetPhoto = createResturantCommand.StreetPhoto,
                ResturantID = new Guid()

            };

            resturant = await _restaurantRepository.AddAsync(resturant);

            var resturantRespone = _mapper.Map<CreateRestaurantResponse>(resturant);

            return resturantRespone;
        }

    }
}
