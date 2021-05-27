
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RestaurantReview.Domain.IRepositories;
using RestaurantReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RestaurantReview.Infrastructure.Repositories
{
    public class RestaurantRepository : BaseRepository<Restaurant>, IRestaurantRepository
    {
        protected new readonly MyDbContext _myDbContext;
        protected readonly IMapper _mapper;

        public RestaurantRepository(MyDbContext myDbContext, IMapper mapper) : base(myDbContext)
        {
            _myDbContext = myDbContext;
            _mapper = mapper;
        }

        public async Task<Restaurant> GetRestaurantByName(string Name)
        {
            var Restaurant = await _myDbContext.Restaurants.Include(Restaurant => Restaurant.Categories).Include(Restaurant => Restaurant.Reviews).FirstOrDefaultAsync(Restaurant => Restaurant.RestaurantName == Name);
            return Restaurant;
        }


       

        public async Task<int> RestaurantReviewCount(string  name)
        {
            var countReview = await _myDbContext.Restaurants.CountAsync(restaurant => restaurant.RestaurantName == name);
           
            return countReview;

        }

        public async Task<List<Restaurant>> IncludeReviews(Guid id)
        {
         var resturantReviews = await _myDbContext.Restaurants.Include(restaurant => restaurant.Reviews).Where(rest => rest.RestaurantID == id).ToListAsync();

            return resturantReviews;
        }



        public Task<bool> IsRestaurantUnique(string name)
        {
            var matches = _myDbContext.Restaurants.Any(restaurant => restaurant.RestaurantName.Equals(name));
            return Task.FromResult(matches);
        }


     


    }



}

