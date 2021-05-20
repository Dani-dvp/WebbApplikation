using AutoMapper;
using RestaurantReview.Application.Features.Authentication.Commands.Login;
using RestaurantReview.Application.Features.Authentication.Commands.Register;
using RestaurantReview.Application.Features.Authentication.Queries.GetUserByEmail;
using RestaurantReview.Application.Features.Categories.Commands.AddRestaurantToCategory;
using RestaurantReview.Application.Features.Categories.Commands.CreateCategory;
using RestaurantReview.Application.Features.Categories.Commands.UpdateCategory;
using RestaurantReview.Application.Features.Categories.Queries.GetCategoryListQuery;
using RestaurantReview.Application.Features.Categories.Queries.GetCategoryQuery;
using RestaurantReview.Application.Features.Restaurants.Commands.AddCategoryToRestaurant;
using RestaurantReview.Application.Features.Restaurants.Commands.CreateRestaurant;
using RestaurantReview.Application.Features.Restaurants.Commands.UpdateRestaurant;
using RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantListQuery;
using RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantQuery;
using RestaurantReview.Application.Features.Restaurants.Queries.RestaurantListQuery.RestaurantReviews;
using RestaurantReview.Application.Features.Restaurants.Queries.RestaurantReviewCountQuery;
using RestaurantReview.Domain.AuthenticationModels;
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


            //from model to CreateModelResponse
            CreateMap<Restaurant, CreateRestaurantResponse>();
            CreateMap<Review, CreateReviewResponse>();
            CreateMap<Category, CreateCategoryResponse>();


            // From model to UpdateModelResponse
            CreateMap<Restaurant, UpdateRestaurantRespone>();

            CreateMap<Category, UpdateCategoryResponse>();



            CreateMap<Review, UpdateReviewResponse>();
            CreateMap<Category, AddRestaurantToCategoryResponse>();



            // from model to ModelDetailResponse
            CreateMap<Restaurant, RestaurantDetailResponse>();
            CreateMap<Category, CategoryDetailQueryResponse>();



            // from model to modelListResponse

            CreateMap<Restaurant, ResturantListQueryResponse>();
            CreateMap<Category, CategoryListQueryResponse>();
            CreateMap<Restaurant, RestaurantReviewsResponse>();



            //From model to ModelResponse
            CreateMap<AuthenticationModel, AuthenticationResponse>();
            CreateMap<RegistrationModel, RegistrationResponse>();

            CreateMap<Restaurant, RestaurantReviewCountResponse>();
            CreateMap<Restaurant, AddCategoryToRestaurantResponse>();



            CreateMap<ApplicationUser, GetUserByEmailResponse>();


            // from model to dto
            CreateMap<Restaurant, ReviewDtoResponse>();
            CreateMap<Review, ReviewDtoResponse>();

        }


    }
}
