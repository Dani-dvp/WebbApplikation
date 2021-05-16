using AutoMapper;
using RestaurantReview.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Categories.Queries.GetAllRestaurantsFromCategoryByNameQuery
{
    public class GetAllRestaurantsFromCategoryByNameHandler : IGetAllRestaurantsFromCategoryByNameService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IMapper _mapper;

        public GetAllRestaurantsFromCategoryByNameHandler(ICategoryRepository categoryRepository, IMapper mapper, IRestaurantRepository restaurantRepository)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
            _restaurantRepository = restaurantRepository;
        }

        public async Task<GetAllRestaurantsFromCategoryByNameResponse> GetAllRestaurantsFromCategoryByName(string categoryName)
        {
            var category = await _categoryRepository.GetCategoryByName(categoryName);

            return _mapper.Map<GetAllRestaurantsFromCategoryByNameResponse>(category);
            // Inte klar ännu får fortsätta senare, lägger samma kommentar i controllern
        }
    }
}
