using System;

namespace RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantListQuery
{
    public class CategoryDtoResponse
    {
        public Guid CategoryID { get; set; }

        public string CategoryName { get; set; }
    }
}