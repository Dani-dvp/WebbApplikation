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
        private readonly IRestaurantRepository _restaurantRepository;


        public CreateReviewHandler(IMapper mapper, IReviewRepository reviewRepository, IRestaurantRepository restaurantRepository)
        {
            _mapper = mapper;
            _reviewRepository = reviewRepository;
            _restaurantRepository = restaurantRepository;

        }

        public async Task<CreateReviewResponse> CreateReview(CreateReviewCommand createReviewCommand)

        {

            var createReviewResponse = new CreateReviewResponse();
            var validator = new CreateReviewCommandValidator();
            var validationResult = await validator.ValidateAsync(createReviewCommand);
            var restaurant = await _restaurantRepository.GetRestaurantByName(createReviewCommand.RestaurantName);

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
                    RestaurantID = restaurant.RestaurantID,
                    RestaurantName = restaurant.RestaurantName,
                    Rating = createReviewCommand.Rating,
                    ReviewText = createReviewCommand.ReviewText,
                    ReviewID = new Guid(),
                    ApplicationUserId = createReviewCommand.ApplicationUserId

                };

                await _reviewRepository.AddAsync(review);

                createReviewResponse = _mapper.Map<CreateReviewResponse>(review);



            };


            return createReviewResponse;




        }

    }
}
