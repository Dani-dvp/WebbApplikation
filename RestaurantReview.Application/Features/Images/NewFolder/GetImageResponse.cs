using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Images.NewFolder
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
