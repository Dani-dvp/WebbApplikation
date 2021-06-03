using System;

namespace RestaurantReview.Application.Features.Categories.Queries.GetCategoryByNameQuery
{
    public class GetRestaurantInCategoryResponse
    {
        public Guid RestaurantID { get; set; }
        public string RestaurantName { get; set; }

        public string RestaurantLink { get; set; }

        public string Description { get; set; }

        public string MapURL { get; set; }
    }
}