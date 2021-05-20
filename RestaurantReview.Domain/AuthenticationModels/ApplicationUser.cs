


using Microsoft.AspNetCore.Identity;
using System;

namespace RestaurantReview.Domain.AuthenticationModels
{
    public class ApplicationUser : IdentityUser
    {
        public Guid ApplicationUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
