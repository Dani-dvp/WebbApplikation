using AutoMapper;
using RestaurantReview.Application.Features.Reviews.Queries.GetReviewsListQuery;
using RestaurantReview.Domain.IRepositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Reviews.Queries.GetReviewListQuery
{
    public class ReviewsListQueryHandler : IReviewListQueryService
    {
        private readonly IMapper _mapper;
        private readonly IReviewRepository _reviewRepository;

        public ReviewsListQueryHandler(IMapper mapper, IReviewRepository reviewRepository)
        {
            _mapper = mapper;
            _reviewRepository = reviewRepository;
        }

        public async Task<List<ReviewListQueryResponse>> GetReviewList()
        {
            var listOfReview = await _reviewRepository.ListAllAsync();

            var listOfReviewResponse = _mapper.Map<List<ReviewListQueryResponse>>(listOfReview);

            return listOfReviewResponse;
        }

    }


}
