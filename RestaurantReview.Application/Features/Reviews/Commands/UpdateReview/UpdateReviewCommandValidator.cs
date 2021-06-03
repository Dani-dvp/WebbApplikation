using FluentValidation;
using ResturantReview.Application.Features.Reviews.Commands.UpdateReview;

namespace RestaurantReview.Application.Features.Reviews.Commands.UpdateReview
{
    public class UpdateReviewCommandValidator : AbstractValidator<UpdateReviewCommand>
    {
        public UpdateReviewCommandValidator()
        {

            RuleFor(p => p.Title)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.")
                .MinimumLength(3).WithMessage("{PropertyName} must contain at least 3 characters.");

            RuleFor(p => p.ReviewText)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(20000).WithMessage("{PropertyName} must not exceed 20.000 characters.")
                .MinimumLength(3).WithMessage("{PropertyName} must contain at least 3 characters.");
        }
    }
}
