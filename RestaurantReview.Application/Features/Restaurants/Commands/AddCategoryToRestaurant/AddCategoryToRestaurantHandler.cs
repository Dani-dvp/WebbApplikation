using AutoMapper;
using RestaurantReview.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Restaurants.Commands.AddCategoryToRestaurant
{
    public class AddCategoryToRestaurantHandler : IAddCategoryToRestaurantService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IMapper _mapper;
        public AddCategoryToRestaurantHandler(ICategoryRepository categoryRepository, IRestaurantRepository restaurantRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _restaurantRepository = restaurantRepository;
            _mapper = mapper;
        }

        public async Task<AddCategoryToRestaurantResponse> AddCategoryToRestaurant(AddCategoryToRestaurantCommand addCategoryToRestaurantCommand)
        {
            var restaurant = await _restaurantRepository.GetRestaurantByName(addCategoryToRestaurantCommand.RestaurantName);

            restaurant.Categories.Add(await _categoryRepository.GetCategoryByName(addCategoryToRestaurantCommand.CategoryName));

            await _restaurantRepository.UpdateAsync(restaurant);

            return _mapper.Map<AddCategoryToRestaurantResponse>(restaurant);

        }
    }
}
