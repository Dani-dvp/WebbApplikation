using RestaurantReview.Domain.AuthenticationModels;
using RestaurantReview.Domain.Models;
using System;

namespace RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantByNameQuery
{
    public class GetImageForRestaurantResponse
    {
        public Guid ImageID { get; set; }

        public string ImgName { get; set; }

        public string ImgPath { get; set; }
#nullable enable
        public string? UserId { get; set; }

        public Guid? RestaurantID { get; set; }

        public Restaurant? Restaurant { get; set; }

        public ApplicationUser? ApplicationUser { get; set; }
    }
}
