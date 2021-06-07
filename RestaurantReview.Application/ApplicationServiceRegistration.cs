
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RestaurantReview.Application.Features.Authentication;
using RestaurantReview.Application.Features.Authentication.Commands.Login;
using RestaurantReview.Application.Features.Authentication.Commands.Register;
using RestaurantReview.Application.Features.Authentication.Queries.CheckTokenIfValid;
using RestaurantReview.Application.Features.Authentication.Queries.GetUserByEmail;
using RestaurantReview.Application.Features.Authentication.Queries.GetUserByUsername;
using RestaurantReview.Application.Features.Categories.Commands.AddRestaurantToCategory;
using RestaurantReview.Application.Features.Categories.Commands.CreateCategory;
using RestaurantReview.Application.Features.Categories.Commands.DeleteCategory;
using RestaurantReview.Application.Features.Categories.Commands.UpdateCategory;
using RestaurantReview.Application.Features.Categories.Queries.GetCategoryByNameQuery;
using RestaurantReview.Application.Features.Categories.Queries.GetCategoryListQuery;
using RestaurantReview.Application.Features.Categories.Queries.GetCategoryQuery;
using RestaurantReview.Application.Features.Images.Commands.CreateImage;
using RestaurantReview.Application.Features.Images.Queries.GetImage;
using RestaurantReview.Application.Features.Restaurants.Commands.AddCategoryToRestaurant;

using RestaurantReview.Application.Features.Restaurants.Commands.CreateRestaurant;
using RestaurantReview.Application.Features.Restaurants.Commands.DeleteRestaurant;
using RestaurantReview.Application.Features.Restaurants.Commands.UpdateRestaurant;
using RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantByNameQuery;
using RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantListQuery;
using RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantQuery;
using RestaurantReview.Application.Features.Restaurants.Queries.GetThreeRandomRestaurants;
using RestaurantReview.Application.Features.Restaurants.Queries.RestauranAvgRating;
using RestaurantReview.Application.Features.Restaurants.Queries.RestaurantAvgRating;
using RestaurantReview.Application.Features.Restaurants.Queries.RestaurantReviewCountQuery;

using RestaurantReview.Application.Features.Reviews.Commands.CreateReview;
using RestaurantReview.Application.Features.Reviews.Commands.DeleteReview;
using RestaurantReview.Application.Features.Reviews.Commands.UpdateReview;
using RestaurantReview.Application.Features.Reviews.Queries.GetReviewListQuery;
using RestaurantReview.Application.Features.Reviews.Queries.GetReviewsListQuery;
using RestaurantReview.Application.Features.Seed.Commands.CreateSeed;
using RestaurantReview.Authentication;
using RestaurantReview.Authentication.AuthenticationRepositories;
using RestaurantReview.Domain.IRepositories;
using RestaurantReview.Infrastructure;
using RestaurantReview.Infrastructure.Repositories;
using ResturantReview.Application.Features.Resturants.Commands.CreateReview;
using ResturantReview.Application.Features.Resturants.Commands.DeleteResturant;
using ResturantReview.Application.Features.Resturants.Commands.UpdateResturant;
using System.Reflection;

namespace RestaurantReview.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {


            //For IRepositories to Repositories
            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IReviewRepository, ReviewRepository>();
            services.AddScoped<IRestaurantRepository, RestaurantRepository>();

            services.AddScoped<ICategoryRepository, CategoryRepository>();

            services.AddScoped<IAuthenticationRepository, AuthenticationRepository>();
            services.AddScoped<IImageRepository, ImageRepository>();



            //For IServices to handler
            //restaurant
            services.AddScoped<ICreateRestaurantService, CreateRestaurantHandler>();

            services.AddScoped<IDeleteRestaurantService, DeleteRestaurantHandler>();
            services.AddScoped<IUpdateRestaurantService, UpdateRestaurantHandler>();
            services.AddScoped<IRestaurantDetailService, RestaurantDetailQueryHandler>();
            services.AddScoped<IRestaurantReviewCountService, RestaurantReviewCountHandler>();
            services.AddScoped<IRestaurantAvgRatingService, RestaurantAvgRatingHandler>();
            services.AddScoped<IGetRestaurantByNameService, GetRestaurantByNameHandler>();
            services.AddScoped<IAddRestaurantToCategoryService, AddRestaurantToCategoryHandler>();
            services.AddScoped<IAddCategoryToRestaurantService, AddCategoryToRestaurantHandler>();
            services.AddScoped<IGetRestaurantListService, GetRestaurantListHandler>();
            services.AddScoped<IGetThreeRandomRestaurantsService, GetThreeRandomRestaurantsHandler>();




            //categories
            services.AddScoped<ICreateCategoryService, CreateCategoryHandler>();
            services.AddScoped<IDeleteCategoryService, DeleteCategoryHandler>();
            services.AddScoped<IUpdateCategoryService, UpdateCategoryHandler>();
            services.AddScoped<ICategoryDetailQueryService, CategoryDetailQueryHandler>();
            services.AddScoped<ICategoryListQueryService, CategoryListQueryHandler>();
            services.AddScoped<IAddCategoryToRestaurantService, AddCategoryToRestaurantHandler>();
            services.AddScoped<IGetCategoryByNameService, GetCategoryByNameHandler>();


            //review 
            services.AddScoped<ICreateReviewService, CreateReviewHandler>();
            services.AddScoped<IDeleteReviewService, DeleteReviewHandler>();
            services.AddScoped<IUpdateReviewService, UpdateReviewHandler>();
            services.AddScoped<IReviewListQueryService, ReviewsListQueryHandler>();

            //image
            services.AddScoped<IImageService, ImageHandler>();

            //Authentication to handler
            services.AddScoped<IAuthenticationService, AuthenticationHandler>();
            services.AddScoped<IRegistrationService, RegistrationHandler>();
            services.AddScoped<IGetUserByEmailService, GetUserByEmailHandler>();
            services.AddScoped<ICheckIfTokenIsValidService, CheckTokenIfValidHandler>();
            services.AddScoped<IGetUserByUsernameService, GetUserByUsernameHandler>();

            //Seedcontroller
            services.AddScoped<ICreateSeedService, CreateSeedHandler>();

            //Aktiverar automapper i Core
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddInfrastructureServices(configuration);

            services.AddScoped<IGetImageService, GetImageHandler>();

            return services;
        }
    }
}
