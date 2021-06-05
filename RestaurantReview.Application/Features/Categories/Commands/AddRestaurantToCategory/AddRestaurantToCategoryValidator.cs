using FluentValidation;

namespace RestaurantReview.Application.Features.Categories.Commands.AddRestaurantToCategory
{

    public class AddRestaurantToCategoryValidator : AbstractValidator<AddRestaurantToCategoryCommand>
    {
        public AddRestaurantToCategoryValidator()
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
