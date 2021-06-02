using AutoMapper;
using RestaurantReview.Domain.IRepositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Categories.Queries.GetCategoryByNameQuery
{
    public class GetCategoryByNameHandler : IGetCategoryByNameService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public GetCategoryByNameHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }


        public async Task<GetCategoryByNameResponse> GetCategoryByName(string categoryname)
        {
            var category = await _categoryRepository.GetCategoryByName(categoryname);


            var categoryResponse = _mapper.Map<GetCategoryByNameResponse>(category);
            categoryResponse.RestaurantResponses = _mapper.Map<List<GetRestaurantInCategoryResponse>>(category.Restaurants);

            return categoryResponse;

        }
    }
}
