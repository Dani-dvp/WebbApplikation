using ResturantReview.Application.Features.Reviews.Commands.DeleteReview;
using System;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Reviews.Commands.DeleteReview
{
    public interface IDeleteReviewService
    {
        Task<Guid> DeleteReview(DeleteReviewCommand deleteReviewCommand);
    }
}
