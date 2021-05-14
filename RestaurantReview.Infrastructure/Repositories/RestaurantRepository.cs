﻿
using Microsoft.EntityFrameworkCore;
using RestaurantReview.Domain.IRepositories;
using RestaurantReview.Domain.Models;
using System;
using System.Threading.Tasks;

namespace RestaurantReview.Infrastructure.Repositories
{
    public class RestaurantRepository : BaseRepository<Restaurant>, IRestaurantRepository
    {
        protected new readonly MyDbContext _myDbContext;



        public RestaurantRepository(MyDbContext myDbContext) : base(myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public async Task<Restaurant> GetRestaurantByName(string Name)
        {
            var Restaurant = await _myDbContext.Set<Restaurant>().FirstOrDefaultAsync(Restaurant => Restaurant.RestaurantName == Name);
            return Restaurant;
        }
        public async Task<int> RestaurantReviewCount(string  name)
        {
            var countReview = await _myDbContext.Set<Restaurant>().CountAsync(restaurant => restaurant.RestaurantName == name);
           
            return countReview;

        }
    }

}

