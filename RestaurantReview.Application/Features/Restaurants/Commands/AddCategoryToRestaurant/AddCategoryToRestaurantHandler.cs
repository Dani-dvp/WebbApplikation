using AutoMapper;
using RestaurantReview.Domain.IRepositories;
using System.Collections.Generic;
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
            var addCategoryToRestaurantResponse = new AddCategoryToRestaurantResponse();
            var validator = new AddCategoryToRestaurantValidator();
            var validationResult = await validator.ValidateAsync(addCategoryToRestaurantCommand);


            if (validationResult.Errors.Count > 0)
            {
                addCategoryToRestaurantResponse.Success = false;
                addCategoryToRestaurantResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    addCategoryToRestaurantResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }

            if (addCategoryToRestaurantResponse.Success)
            {
                var restaurant = await _restaurantRepository.GetRestaurantByName(addCategoryToRestaurantCommand.RestaurantName);

                restaurant.Categories.Add(await _categoryRepository.GetCategoryByName(addCategoryToRestaurantCommand.CategoryName));

                await _restaurantRepository.UpdateAsync(restaurant);

                addCategoryToRestaurantResponse = _mapper.Map<AddCategoryToRestaurantResponse>(restaurant);

            }


            return addCategoryToRestaurantResponse;


            

        }
    }
}
