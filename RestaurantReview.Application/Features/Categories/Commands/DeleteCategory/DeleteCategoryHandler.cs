
using RestaurantReview.Domain.IRepositories;
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

            var CategoryToBeDeleted = await _categoryRepository.GetCategoryByName(deleteCategoryCommand.CategoryName);

            await _categoryRepository.DeleteAsync(CategoryToBeDeleted);

            return CategoryToBeDeleted.CategoryName;
        }
    }
}
