﻿using RestaurantReview.Application.ValidationResponse;
using System;

namespace RestaurantReview.Application.Features.Restaurants.Commands.UpdateRestaurant
{
    public class UpdateRestaurantCommand : BaseResponse
    {
        public Guid RestaurantID { get; set; }
        public string RestaurantName { get; set; }

        public string RestaurantLink { get; set; }

        public string Description { get; set; }

        public string MapURL { get; set; }

        public string TempImage { get; set; }
    }
}