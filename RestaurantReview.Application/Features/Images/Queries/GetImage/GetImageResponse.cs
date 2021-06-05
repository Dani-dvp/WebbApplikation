using System;

namespace RestaurantReview.Application.Features.Images.Queries.GetImage
{
    public class GetImageResponse
    {

        public Guid ImageID { get; set; }

        public string ImgName { get; set; }

        public string ImgPath { get; set; }
#nullable enable
        public string? UserId { get; set; }
    }
}
