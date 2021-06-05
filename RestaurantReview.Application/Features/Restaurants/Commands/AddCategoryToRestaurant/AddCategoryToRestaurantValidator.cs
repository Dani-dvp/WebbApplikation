using FluentValidation;

namespace RestaurantReview.Application.Features.Restaurants.Commands.AddCategoryToRestaurant
{

    public class AddCategoryToRestaurantValidator : AbstractValidator<AddCategoryToRestaurantCommand>
    {
        public AddCategoryToRestaurantValidator()
        {
            RuleFor(p => p.RestaurantName)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.")
                .MinimumLength(3).WithMessage("{PropertyName} must contain at least 3 characters.");

            RuleFor(p => p.CategoryName)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.")
                .MinimumLength(3).WithMessage("{PropertyName} must contain at least 3 characters.");

        }
    }
}
