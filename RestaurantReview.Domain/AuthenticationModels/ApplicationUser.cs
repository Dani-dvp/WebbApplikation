


using Microsoft.AspNetCore.Identity;
using RestaurantReview.Domain.Models;
using System.Collections.Generic;

namespace RestaurantReview.Domain.AuthenticationModels
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Images = new List<Image>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Image> Images { get; set; }
    }
}
