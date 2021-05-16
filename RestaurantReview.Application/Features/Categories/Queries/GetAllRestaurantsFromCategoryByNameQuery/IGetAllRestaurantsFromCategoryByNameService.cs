using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Categories.Queries.GetAllRestaurantsFromCategoryByNameQuery
{
    public interface IGetAllRestaurantsFromCategoryByNameService
    {
        Task<GetAllRestaurantsFromCategoryByNameResponse> GetAllRestaurantsFromCategoryByName(string categoryName);
    }
}
