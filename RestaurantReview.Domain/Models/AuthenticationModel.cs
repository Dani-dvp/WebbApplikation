using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantReview.Domain.Models
{
    public class AuthenticationModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
