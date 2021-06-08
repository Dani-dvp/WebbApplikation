using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Authentication.Commands.DeleteUserByUserName
{
    public class DeleteUserByUsernameCommand
    {
        public string Username { get; set; }
    }
}
