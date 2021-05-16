using AutoMapper;
using RestaurantReview.Application.Features.Reviews.Commands.UpdateReview;
using RestaurantReview.Domain.IRepositories;
using ResturantReview.Application.Features.Reviews.Commands.UpdateReview;
using System.Threading.Tasks;

namespace ResturantReview.Application.Features.Resturants.Commands.UpdateResturant
{
    public class UpdateReviewHandler : IUpdateReviewService
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IMapper _mapper;
        public UpdateReviewHandler(IMapper mapper, IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
            _mapper = mapper;
        }

        public async Task<UpdateReviewResponse> UpdateReview(UpdateReviewCommand updateReviewCommand)
        {
            var reviewToBeUpdated = await _reviewRepository.GetByIdAsync(updateReviewCommand.ReviewID);

            reviewToBeUpdated.ReviewText = updateReviewCommand.ReviewText;
            reviewToBeUpdated.Rating = updateReviewCommand.Rating;


            await _reviewRepository.UpdateAsync(reviewToBeUpdated);

            var updateReviewResponse = _mapper.Map<UpdateReviewResponse>(reviewToBeUpdated);

            return updateReviewResponse;


        }

    }
}
