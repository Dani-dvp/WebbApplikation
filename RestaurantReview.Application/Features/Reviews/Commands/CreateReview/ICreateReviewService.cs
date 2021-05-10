using ResturantReview.Application.Features.Resturants.Commands.CreateReview;
using ResturantReview.Application.Features.Reviews.Commands.CreateReview;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Reviews.Commands.CreateReview
{
    public interface ICreateReviewService
    {
        Task<CreateReviewResponse> CreateReview(CreateReviewCommand createReviewCommand);
    }
}
