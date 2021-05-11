using Microsoft.AspNetCore.Mvc;

using RestaurantReview.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Categories.Commands.DeleteCategory
{
   public class DeleteCategoryHandler : IDeleteCategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public DeleteCategoryHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;

        }

        public async Task<string> DeleteCategory(DeleteCategoryCommand deleteCategoryCommand)
        {

       var CategoryToBeDeleted = await _categoryRepository.GetCategoryByName(deleteCategoryCommand.RestaurantCategory);

          await  _categoryRepository.DeleteAsync(CategoryToBeDeleted);

            return CategoryToBeDeleted.RestaurantCategory;
        } 
    }
}
