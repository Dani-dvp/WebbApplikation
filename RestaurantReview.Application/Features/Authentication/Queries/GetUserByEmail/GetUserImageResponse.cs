using System;

namespace RestaurantReview.Application.Features.Authentication.Queries.GetUserByEmail
{
    public class GetUserImageResponse
    {
        public Guid ImageID { get; set; }

        public string ImgName { get; set; }

        public string ImgPath { get; set; }

        public string UserId { get; set; }

        public Guid RestaurantID { get; set; }
    }
}