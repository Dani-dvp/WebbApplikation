using FluentValidation;
using ResturantReview.Application.Features.Reviews.Commands.UpdateReview;

namespace RestaurantReview.Application.Features.Reviews.Commands.UpdateReview
{
    public class UpdateReviewCommandValidator : AbstractValidator<UpdateReviewCommand>
    {
        public UpdateReviewCommandValidator()
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
