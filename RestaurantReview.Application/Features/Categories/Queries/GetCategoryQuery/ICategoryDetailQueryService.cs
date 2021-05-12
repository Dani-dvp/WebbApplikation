using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Categories.Queries.GetCategoryQuery
{
    public interface ICategoryDetailQueryService
    {
        Task<CategoryDetailQueryResponse> GetCategoryByID(CategoryDetailQueryCommand categoryDetailQueryCommand);
    }
}
