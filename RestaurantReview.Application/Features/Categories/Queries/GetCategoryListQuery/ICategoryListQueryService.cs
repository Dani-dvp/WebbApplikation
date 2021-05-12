using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Categories.Queries.GetCategoryListQuery
{
    public interface ICategoryListQueryService
    {
        Task<List<CategoryListQueryResponse>> GetCategoryList();
    }
}
