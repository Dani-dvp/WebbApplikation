using RestaurantReview.Domain.Models;
using System;
using System.Collections.Generic;

namespace RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantByNameQuery
{
    public class GetRestaurantByNameResponse
    {
        public Guid RestaurantID { get; set; }

        public string RestaurantName { get; set; }

        public string RestaurantLink { get; set; }

        public string Description { get; set; }

        public string MapUrl { get; set; }

        public string TempImage { get; set; }

        public GetImageForRestaurantResponse GetImageForRestaurantResponse { get; set; }

        public ICollection<ReviewDtoResponse> ReviewsDtoResponse { get; set; }

        public ICollection<Category> Categories { get; set; }


    }
}
