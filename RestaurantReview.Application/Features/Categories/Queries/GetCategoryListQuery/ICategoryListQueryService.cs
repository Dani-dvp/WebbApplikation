using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Categories.Queries.GetCategoryListQuery
{
    public interface ICategoryListQueryService
    {
        Task<List<CategoryListQueryResponse>> GetCategoryList();
    }
}
