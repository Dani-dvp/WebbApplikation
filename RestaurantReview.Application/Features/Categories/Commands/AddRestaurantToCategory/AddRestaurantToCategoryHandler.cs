using AutoMapper;
using RestaurantReview.Domain.IRepositories;
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
            var category = await _categoryRepository.GetCategoryByName(addRestaurantToCategoryCommand.CategoryName);

            category.Restaurants.Add(await _restaurantRepository.GetRestaurantByName(addRestaurantToCategoryCommand.RestaurantName));

            await _categoryRepository.UpdateAsync(category);

            return _mapper.Map<AddRestaurantToCategoryResponse>(category);

        }

    }
}
