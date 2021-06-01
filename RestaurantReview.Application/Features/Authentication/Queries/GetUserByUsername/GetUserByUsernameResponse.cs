using RestaurantReview.Application.Features.Authentication.Queries.GetUserByEmail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Authentication.Queries.GetUserByUsername
{
    public class GetUserByUsernameResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }

        public GetUserImageResponse GetUserImageResponse { get; set; }

        public List<GetUserByUsernameReview> GetUserByUsernameReviews { get; set; }
    }
}
