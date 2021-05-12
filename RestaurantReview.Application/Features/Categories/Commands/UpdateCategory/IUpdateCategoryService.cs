using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Categories.Commands.UpdateCategory
{
    public interface IUpdateCategoryService
    {
        Task<UpdateCategoryResponse> UpdateCategory(UpdateCategoryCommand updateCategoryCommand);
    }
}
