using AutoMapper;
using RestaurantReview.Application.Features.Reviews.Commands.UpdateReview;
using RestaurantReview.Domain.IRepositories;
using RestaurantReview.Domain.Models;
using ResturantReview.Application.Features.Reviews.Commands.UpdateReview;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ResturantReview.Application.Features.Resturants.Commands.UpdateResturant
{
    public class UpdateReviewHandler : IUpdateReviewService
    {
        private readonly IMapper _mapper;
        private readonly IReviewRepository _reviewRepository;

        public UpdateReviewHandler(IMapper mapper, IReviewRepository reviewRepository)
        {
            _mapper = mapper;
            _reviewRepository = reviewRepository;
        }


        public async Task<UpdateReviewResponse> UpdateReview(UpdateReviewCommand updateReviewCommand)
        {
            var updateReviewResponse = new UpdateReviewResponse();



            var validator = new UpdateReviewCommandValidator();
            var validationResult = await validator.ValidateAsync(updateReviewCommand);




            if (validationResult.Errors.Count > 0)
            {
                updateReviewResponse.Success = false;
                updateReviewResponse.ValidationErrors = new List<string>();

                foreach (var error in validationResult.Errors)
                {
                    updateReviewResponse.ValidationErrors.Add(error.ErrorMessage);
                }

            }

            if (updateReviewResponse.Success)
            {
                var review = new Review()

                {

                    ReviewText = updateReviewCommand.ReviewText,
                    Rating = updateReviewCommand.Rating,
                };

                await _reviewRepository.UpdateAsync(review);

                updateReviewResponse = _mapper.Map<UpdateReviewResponse>(review);

            }

            return updateReviewResponse;
        }

    }
}
