using RestaurantReview.Application.Features.Restaurants.Queries.RestaurantListQuery.RestaurantReviews;
using RestaurantReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantByNameQuery
{
    public class GetRestaurantByNameResponse
    {
        public Guid RestaurantID { get; set; }

        public string RestaurantName { get; set; }

        public string RestaurantLink { get; set; }

        public string GoogleMapsPhoto { get; set; }

        public string StreetPhoto { get; set; }

        public ICollection<ReviewDtoResponse> ReviewsDtoResponse { get; set; }


    }
}
