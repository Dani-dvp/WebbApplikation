using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ResturantReview.Application.Features.Restaurants.Commands.CreateRestaurant;
using ResturantReview.Application.Features.Restaurants.Queries.GetRestaurantListQuery;
using ResturantReview.Domain.IRepositories;
using ResturantReview.Infrastructure;
using ResturantReview.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ResturantReview.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {


            //For IRepositories to Repositories
            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>)); 
            services.AddScoped<IReviewRepository, ReviewRepository>();
            services.AddScoped<IRestaurantRepository, RestaurantRepository>();


            //For IServices to handler
            services.AddScoped<ICreateRestaurantService, CreateRestaurantHandler>();



            //Aktiverar automapper i Core
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddInfrastructureServices(configuration);

            return services;
        }
    }
}
