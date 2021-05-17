using RestaurantReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Restaurants.Queries.RestaurantListQuery.RestaurantReviews
{
    public class RestaurantReviewsResponse
    {
        public string RestaurantName { get; set; }
        public RestaurantReviewsResponse()
        {
            ReviewsDtoResponses = new List<ReviewDtoResponse>();
        }
     
        
        public ICollection<ReviewDtoResponse> ReviewsDtoResponses;




    }
}
