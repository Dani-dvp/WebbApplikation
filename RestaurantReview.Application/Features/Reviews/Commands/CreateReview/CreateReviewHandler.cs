﻿using AutoMapper;
using RestaurantReview.Application.Features.Reviews.Commands.CreateReview;
using RestaurantReview.Domain.IRepositories;
using RestaurantReview.Domain.Models;
using ResturantReview.Application.Features.Reviews.Commands.CreateReview;
using System;
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

        //Kolla eventuellt här för fel!!! Fick felmeddelanden men fixde det med att välja alt. från pot. fix
        public async Task<CreateReviewResponse> CreateReview(CreateReviewCommand createReviewCommand)

        {
            var review = new Review()

            {

                Title = createReviewCommand.Title,
                Summary = createReviewCommand.Summary,
                Rating = createReviewCommand.Rating,
                ReviewText = createReviewCommand.ReviewText,
                ReviewID = new Guid()
            };

            review = await _reviewRepository.AddAsync(review);

            var reviewRespone = _mapper.Map<CreateReviewResponse>(review);

            return reviewRespone;
        }

    }
}