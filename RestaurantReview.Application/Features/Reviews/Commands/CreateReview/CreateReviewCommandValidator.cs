using FluentValidation;
using ResturantReview.Application.Features.Reviews.Commands.CreateReview;

namespace RestaurantReview.Application.Features.Reviews.Commands.CreateReview
{
    public class CreateReviewCommandValidator : AbstractValidator<CreateReviewCommand>
    {
        public CreateReviewCommandValidator()
        {


            RuleFor(p => p.ReviewText)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(20000).WithMessage("{PropertyName} must not exceed 20.000 characters.")
                .MinimumLength(3).WithMessage("{PropertyName} must contain at least 3 characters.");

            RuleFor(p => p.Rating)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .ExclusiveBetween(0, 6).WithMessage("{PropertyName} must be between 1-5.");
        }
    }
}
