using AutoMapper;
using RestaurantReview.Domain.IRepositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Categories.Commands.AddRestaurantToCategory
{
    public class AddRestaurantToCategoryHandler : IAddRestaurantToCategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IMapper _mapper;

        public AddRestaurantToCategoryHandler(IMapper mapper, ICategoryRepository categoryRepository, IRestaurantRepository restaurantRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
            _restaurantRepository = restaurantRepository;
        }

        public async Task<AddRestaurantToCategoryResponse> AddRestaurantToCategory(AddRestaurantToCategoryCommand addRestaurantToCategoryCommand)
        {
            var addRestaurantToCategoryResponse = new AddRestaurantToCategoryResponse();
            var validator = new AddRestaurantToCategoryValidator();
            var validationResult = await validator.ValidateAsync(addRestaurantToCategoryCommand);


            if (validationResult.Errors.Count > 0)
            {
                addRestaurantToCategoryResponse.Success = false;
                addRestaurantToCategoryResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    addRestaurantToCategoryResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }

            if (addRestaurantToCategoryResponse.Success)
            {
                var category = await _categoryRepository.GetCategoryByName(addRestaurantToCategoryCommand.CategoryName);

                category.Restaurants.Add(await _restaurantRepository.GetRestaurantByName(addRestaurantToCategoryCommand.RestaurantName));

                await _categoryRepository.UpdateAsync(category);
                addRestaurantToCategoryResponse = _mapper.Map<AddRestaurantToCategoryResponse>(category);

            }


            return addRestaurantToCategoryResponse;

        }

    }
}
