using AutoMapper;
using RestaurantReview.Application.Features.Restaurants.Commands.CreateRestaurant;
using RestaurantReview.Application.Features.Restaurants.Commands.UpdateRestaurant;
using RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantListQuery;
using RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantQuery;
using RestaurantReview.Domain.Models;
using ResturantReview.Application.Features.Resturants.Commands.CreateReview;
using ResturantReview.Application.Features.Reviews.Commands.UpdateReview;

namespace RestaurantReview.Application.Profiles
{
    public class MappingProfile : Profile // profile från automapper
    {
        //Här är automapper configuration:

        //CreateMap<FrånModel, TillModel>();
        // Så en riktig hade sett ut såhär:

        public MappingProfile()
        {
            // Från Model, till CreateModelResponse

            //from model to CreateModelResponse
            CreateMap<Restaurant, CreateRestaurantResponse>();
            CreateMap<Review, CreateReviewResponse>();

            // From model to UpdateModelResponse
            CreateMap<Restaurant, UpdateRestaurantRespone>();
            CreateMap<Review, UpdateReviewResponse>();


            // from model to ModelDetailResponse
            CreateMap<Restaurant, RestaurantDetalResponse>();
            
            // from modelList to modelListResponse

            CreateMap<Restaurant, RestaurantListQueryResponse>();

        }


    }
}
