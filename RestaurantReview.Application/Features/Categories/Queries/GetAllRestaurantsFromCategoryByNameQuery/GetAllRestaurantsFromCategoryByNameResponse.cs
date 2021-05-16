using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Categories.Queries.GetAllRestaurantsFromCategoryByNameQuery
{
    public class GetAllRestaurantsFromCategoryByNameResponse
    {
        public GetAllRestaurantsFromCategoryByNameResponse()
        {
            RestaurantFromCategoryResponses = new List<RestaurantFromCategoryResponse>();
        }
        public string CategoryName { get; set; }

        public ICollection<RestaurantFromCategoryResponse> RestaurantFromCategoryResponses { get; set; }
    }
}
