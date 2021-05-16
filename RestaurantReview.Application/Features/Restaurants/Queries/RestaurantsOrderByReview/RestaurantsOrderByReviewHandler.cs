using AutoMapper;
using RestaurantReview.Domain.IRepositories;
using RestaurantReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace RestaurantReview.Application.Features.Restaurants.Queries.RestaurantsOrderByReview
{
    public class RestaurantsOrderByReviewHandler
    {

        private readonly IMapper _mapper;
        private readonly IRestaurantRepository _restaurantRepository;


        public RestaurantsOrderByReviewHandler(IMapper mapper, IRestaurantRepository restaurantRepository)
        {
            _mapper = mapper;
            _restaurantRepository = restaurantRepository;
        }

       
    }

}