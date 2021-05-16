using AutoMapper;
using RestaurantReview.Domain.IRepositories;
using RestaurantReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryHandler : ICreateCategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CreateCategoryHandler(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }


        public async Task<CreateCategoryResponse> CreateCategory(CreateCategoryCommand createCategoryCommand)
        {
            var category = new Category
            {
                RestaurantCategory = createCategoryCommand.RestaurantCategory,
                CategoryID = new Guid(),
                Restaurants = new List<Restaurant>()

            };


            category = await _categoryRepository.AddAsync(category);

            var categoryResponse = _mapper.Map<CreateCategoryResponse>(category);

            return categoryResponse;




        }

    }
}
