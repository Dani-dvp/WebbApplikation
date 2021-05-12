using AutoMapper;
using RestaurantReview.Domain.IRepositories;
using RestaurantReview.Domain.Models;
using System;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Restaurants.Commands.CreateRestaurant
{
    public class CreateRestaurantHandler : ICreateRestaurantService
    {
        //Innehåller kod för metoder, sparar detta sedan genom att kalla på Repository för sin klass

        //Får inte returnera en vanlig "Model" Måste Returner en ResponsTyp med innehållet man vill visa.
        private readonly IMapper _mapper;
        private readonly IRestaurantRepository _restaurantRepository;


        public CreateRestaurantHandler(IMapper mapper, IRestaurantRepository restaurantRepository)
        {
            _mapper = mapper;
            _restaurantRepository = restaurantRepository;
        }

        public async Task<CreateRestaurantResponse> CreateRestaurant(CreateRestaurantCommand createRestaurantCommand)
        {
            var Restaurant = new Restaurant()
            {
                RestaurantName = createRestaurantCommand.RestaurantName,
                Category = createRestaurantCommand.Category,
                StreetPhoto = createRestaurantCommand.StreetPhoto,
                RestaurantID = new Guid()

            };

            Restaurant = await _restaurantRepository.AddAsync(Restaurant);

            var RestaurantRespone = _mapper.Map<CreateRestaurantResponse>(Restaurant);

            return RestaurantRespone;


        }

    }
}
