using System;

namespace RestaurantReview.Application.Features.Categories.Queries.GetAllRestaurantsFromCategoryByNameQuery
{
    public class RestaurantFromCategoryResponse
    {
        public Guid RestaurantID { get; set; }
        public string RestaurantName { get; set; }
    }
}