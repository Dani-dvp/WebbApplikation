using Microsoft.AspNetCore.Identity;
using RestaurantReview.Domain.AuthenticationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Authentication.Commands.DeleteUserByUserName
{
    public class DeleteUserByUsernameHandler : IDeleteUserByUsernameService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public DeleteUserByUsernameHandler(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<bool> DeleteUserByUsername(DeleteUserByUsernameCommand deleteUserByUsernameCommand)
        {
            var user = await _userManager.FindByNameAsync(deleteUserByUsernameCommand.Username);
            if(user != null)
            {
                await _userManager.DeleteAsync(user);
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
