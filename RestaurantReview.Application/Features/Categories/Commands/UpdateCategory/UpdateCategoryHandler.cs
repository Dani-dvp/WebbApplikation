using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestaurantReview.Domain.IRepositories;
using RestaurantReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Categories.Commands.UpdateCategory
{
    public class UpdateCategoryHandler : IUpdateCategoryService
    {
        protected readonly ICategoryRepository _categoryRepository;
        protected readonly IMapper _mapper;
        public UpdateCategoryHandler(ICategoryRepository categoryRepository , IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }



        public async Task<UpdateCategoryResponse> UpdateCategory (UpdateCategoryCommand updateCategoryCommand) 
        {
       var categoryToBeUpdated = await _categoryRepository.GetCategoryByName(updateCategoryCommand.RestaurantCategory);

            categoryToBeUpdated.RestaurantCategory = updateCategoryCommand.RestaurantCategory;

       
          await _categoryRepository.UpdateAsync(categoryToBeUpdated);

            var updateCategoryResponse = _mapper.Map<UpdateCategoryResponse>(categoryToBeUpdated);

            return updateCategoryResponse;



        }
    }
}
