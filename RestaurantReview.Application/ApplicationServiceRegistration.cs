using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RestaurantReview.Application.Features.Categories.Commands.CreateCategory;
using RestaurantReview.Application.Features.Categories.Commands.DeleteCategory;
using RestaurantReview.Application.Features.Categories.Commands.UpdateCategory;
using RestaurantReview.Application.Features.Categories.Queries.GetCategoryListQuery;
using RestaurantReview.Application.Features.Categories.Queries.GetCategoryQuery;
using RestaurantReview.Application.Features.Restaurants.Commands.CreateRestaurant;
using RestaurantReview.Application.Features.Restaurants.Commands.DeleteRestaurant;
using RestaurantReview.Application.Features.Restaurants.Commands.UpdateRestaurant;
using RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantListQuery;
using RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantQuery;
using RestaurantReview.Domain.IRepositories;
using RestaurantReview.Infrastructure;
using RestaurantReview.Infrastructure.Repositories;
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


            //For IServices to handler
            //restaurant
            services.AddScoped<ICreateRestaurantService, CreateRestaurantHandler>();
            services.AddScoped<IDeleteRestaurantService, DeleteRestaurantHandler>();
            services.AddScoped<IUpdateRestaurantService, UpdateRestaurantHandler>();
            services.AddScoped<ICategoryListQuery, RestaurantListQueryHandler>();
            services.AddScoped<IRestaurantDetailService, RestaurantDetailQueryHandler>();

            //categories
            services.AddScoped<ICreateCategoryService, CreateCategoryHandler>();
            services.AddScoped<IDeleteCategoryService, DeleteCategoryHandler>();
            services.AddScoped<IUpdateCategoryService, UpdateCategoryHandler>();
           services.AddScoped<ICategoryDetailQueryService, CategoryDetailQueryHandler>();
            services.AddScoped<ICategoryListQueryService, CategoryListQueryHandler>();


            //Aktiverar automapper i Core
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddInfrastructureServices(configuration);

            return services;
        }
    }
}
