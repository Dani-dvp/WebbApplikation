using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RestaurantReview.Application.Features.Authentication;
using RestaurantReview.Application.Features.Authentication.Commands.Authenticate;
using RestaurantReview.Application.Features.Authentication.Commands.Register;
using RestaurantReview.Application.Features.Restaurants.Commands.CreateRestaurant;
<<<<<<< HEAD
using RestaurantReview.Authentication;
using RestaurantReview.Authentication.AuthenticationRepositories;
=======
using RestaurantReview.Application.Features.Reviews.Commands.CreateReview;
using RestaurantReview.Application.Features.Reviews.Commands.DeleteReview;
using RestaurantReview.Application.Features.Reviews.Commands.UpdateReview;
using RestaurantReview.Application.Features.Reviews.Queries.GetReviewListQuery;
using RestaurantReview.Application.Features.Reviews.Queries.GetReviewsListQuery;
>>>>>>> main
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
            services.AddScoped<IAuthenticationRepository, AuthenticationRepository>();


            //For IServices to handler
            services.AddScoped<ICreateRestaurantService, CreateRestaurantHandler>();
<<<<<<< HEAD

            //Authentication to handler
            services.AddScoped<IAuthenticationService, AuthenticationHandler>();
            services.AddScoped<IRegistrationService, RegistrationHandler>();

=======
            services.AddScoped<ICreateReviewService, CreateReviewHandler>();
            services.AddScoped<IDeleteReviewService, DeleteReviewHandler>();
            services.AddScoped<IUpdateReviewService, UpdateReviewHandler>();
            services.AddScoped<IReviewListQueryService, ReviewsListQueryHandler>();
>>>>>>> main


            //Aktiverar automapper i Core
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddInfrastructureServices(configuration);
            services.AddAuthenticationServices(configuration);

            return services;
        }
    }
}
