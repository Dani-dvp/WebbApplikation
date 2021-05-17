using AutoMapper;
using RestaurantReview.Application.Features.Reviews.Commands.CreateReview;
using RestaurantReview.Domain.IRepositories;
using RestaurantReview.Domain.Models;
using ResturantReview.Application.Features.Reviews.Commands.CreateReview;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ResturantReview.Application.Features.Resturants.Commands.CreateReview
{
    public class CreateReviewHandler : ICreateReviewService
    {
        //Innehåller kod för metoder, sparar detta sedan genom att kalla på Repository för sin klass

        //Får inte returnera en vanlig "Model" Måste Returner en ResponsTyp med innehållet man vill visa.
        private readonly IMapper _mapper;
        private readonly IReviewRepository _reviewRepository;


        public CreateReviewHandler(IMapper mapper, IReviewRepository reviewRepository)
        {
            _mapper = mapper;
            _reviewRepository = reviewRepository;

        }
       
        public async Task<CreateReviewResponse> CreateReview(CreateReviewCommand createReviewCommand)

        {

            var createReviewResponse = new CreateReviewResponse();
            var validator = new CreateReviewCommandValidator();
            var validationResult = await validator.ValidateAsync(createReviewCommand);

            if (validationResult.Errors.Count > 0)
            {

                createReviewResponse.Success = false;
                createReviewResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    createReviewResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }

            if (createReviewResponse.Success)
            {
                var review = new Review()
                {
                    Title = createReviewCommand.Title,
                    Summary = createReviewCommand.Summary,
                    Rating = createReviewCommand.Rating,
                    ReviewText = createReviewCommand.ReviewText,
                    ReviewID = new Guid()
                };

                 await _reviewRepository.AddAsync(review);

                createReviewResponse = _mapper.Map<CreateReviewResponse>(review);


            };


            return createReviewResponse;




        }

    }
}
