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

            var categoryResponse = new CreateCategoryResponse();
            var validator = new CreateCategoryCommandValidator(_categoryRepository);
            var validationResult = await validator.ValidateAsync(createCategoryCommand);


            if (validationResult.Errors.Count > 0)
            {
                categoryResponse.Success = false;
                categoryResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    categoryResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }

            if (categoryResponse.Success)
            { 
                var category = new Category()
                {
                    RestaurantCategory = createCategoryCommand.RestaurantCategory,
                    CategoryID = new Guid(),

                };
                  
                 await _categoryRepository.AddAsync(category);
                categoryResponse = _mapper.Map<CreateCategoryResponse>(category);

            }
            
            return categoryResponse;

        }

    }
}
