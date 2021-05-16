using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Authentication.Queries.GetUserByEmail
{
    public class GetUserByEmailCommand
    {
        public string Email { get; set; }
    }
}
