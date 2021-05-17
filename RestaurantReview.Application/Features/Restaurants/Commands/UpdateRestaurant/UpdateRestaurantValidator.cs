using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Restaurants.Commands.UpdateRestaurant
{
    public class UpdateRestaurantValidator : AbstractValidator<UpdateRestaurantCommand>
    {
        public UpdateRestaurantValidator()
         {
            RuleFor(p => p.RestaurantName)
                    .NotEmpty().WithMessage("{PropertyName} is required.")
                    .NotNull()
                    .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.")
                    .MinimumLength(3).WithMessage("{PropertyName} must contain at least 3 characters.");

    }
}
}
  