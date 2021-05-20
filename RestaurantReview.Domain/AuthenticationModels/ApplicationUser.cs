


using Microsoft.AspNetCore.Identity;
using System;

namespace RestaurantReview.Domain.AuthenticationModels
{
    public class ApplicationUser : IdentityUser
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
