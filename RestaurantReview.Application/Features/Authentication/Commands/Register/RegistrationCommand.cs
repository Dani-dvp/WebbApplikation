using System.ComponentModel.DataAnnotations;



namespace RestaurantReview.Application.Features.Authentication.Commands.Register
{
    public class RegistrationCommand
    {

        public string FirstName { get; set; }


        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        public string UserName { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }
    }
}
