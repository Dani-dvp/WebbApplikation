
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
            var Restaurant = await _myDbContext.Restaurants.FirstOrDefaultAsync(Restaurant => Restaurant.RestaurantName == Name);
            return Restaurant;
        }

       

        public async Task<int> RestaurantReviewCount(string  name)
        {
            var countReview = await _myDbContext.Set<Restaurant>().CountAsync(restaurant => restaurant.RestaurantName == name);
           
            return countReview;

        }


        public async Task<Restaurant> RestaurantAndReviews(string Name)
        {


          // var RestaurantAndReviews = await _myDbContext.Restaurants.Include(rest => rest.Reviews).Where(rest => rest.RestaurantName == name) //FirstOrDefaultAsync(Restaurant => Restaurant.RestaurantName == Name);
            return null;

        }





    }



}

