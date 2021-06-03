using RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantByNameQuery;
using System;
using System.Collections.Generic;

namespace RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantListQuery
{
    public class GetRestaurantListResponse
    {

        public Guid RestaurantID { get; set; }
        public string RestaurantName { get; set; }

        public string RestaurantLink { get; set; }

        public string Description { get; set; }

        public string MapURL { get; set; }

        public string TempImage { get; set; }

        public ICollection<ImageDtoResponse> ImageDtoResponses { get; set; }

        public ICollection<ReviewDtoResponse> ReviewDtoResponses { get; set; }

        public ICollection<CategoryDtoResponse> CategoryDtoResponses { get; set; }

    }
}
