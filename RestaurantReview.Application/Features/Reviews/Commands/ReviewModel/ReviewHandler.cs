using AutoMapper;
using RestaurantReview.Domain.IRepositories;
using RestaurantReview.Domain.Models;
using System;
using System.Threading.Tasks;


namespace RestaurantReview.Application.Features.Reviews.Commands.ReviewModel
{
    public class CategoryHandler : ICategoryService
    {

        private readonly IMapper _mapper;
        private readonly IReviewRepository _reviewRepository;


        public CategoryHandler(IMapper mapper, IReviewRepository reviewRepository)
        {
            _mapper = mapper;
            _reviewRepository = reviewRepository;



        }

        public async Task<Action> Restaurant( )
        {
            return null;
        }
    }
}
