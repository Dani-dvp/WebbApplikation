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

        public List<Restaurant> Restaurants { get; set; }

   
    }
}
