using RestaurantReview.Domain.AuthenticationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RestaurantReview.Domain.Models
{
    public class Image
    {
        public Guid ImageID { get; set; }

        public string ImgName { get; set;}

        public string ImgPath { get; set; }
#nullable enable
        public string? UserId { get; set; }

        public Guid? RestaurantID { get; set; }

        public Restaurant? Restaurant { get; set; }

        public ApplicationUser? ApplicationUser { get; set; }


    }
}
