using RestaurantReview.Application.Features.Reviews.Commands.DeleteReview;
using RestaurantReview.Domain.IRepositories;
using ResturantReview.Application.Features.Reviews.Commands.DeleteReview;
using System;
using System.Threading.Tasks;

namespace ResturantReview.Application.Features.Resturants.Commands.DeleteResturant
{
    public class DeleteReviewHandler : IDeleteReviewService
    {
        private readonly IReviewRepository _reviewRepository;


        public DeleteReviewHandler(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }


        public async Task<Guid> DeleteReview(DeleteReviewCommand deleteReviewCommand)
        {

            var reviewToBeDeleted = await _reviewRepository.GetByIdAsync(deleteReviewCommand.ReviewID);

            await _reviewRepository.DeleteAsync(reviewToBeDeleted);

            return reviewToBeDeleted.ReviewID;
        }

    }
}
