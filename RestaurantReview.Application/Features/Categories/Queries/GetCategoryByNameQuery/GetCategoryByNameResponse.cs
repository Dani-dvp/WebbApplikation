using System;
using System.Collections.Generic;

namespace RestaurantReview.Application.Features.Categories.Queries.GetCategoryByNameQuery
{
    public class GetCategoryByNameResponse
    {
        public GetCategoryByNameResponse()
        {
            RestaurantResponses = new List<GetRestaurantInCategoryResponse>();
        }


        public Guid CategoryID { get; set; }

        public string CategoryName { get; set; }

        public ICollection<GetRestaurantInCategoryResponse> RestaurantResponses { get; set; }
    }
}
