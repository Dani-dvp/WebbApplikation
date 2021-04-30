using AutoMapper;
using ResturantReview.Application.Features.Restaurants.Commands.CreateRestaurant;
using ResturantReview.Application.Features.Restaurants.Commands.UpdateRestaurant;
using ResturantReview.Application.Features.Restaurants.Queries.GetRestaurantQuery;
using ResturantReview.Application.Features.Resturants.Queries.GetResturantListQuery;
using ResturantReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ResturantReview.Application.Profiles
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
            CreateMap<Resturant, CreateRestaurantResponse>();
          
            
            // From model to UpdateModelResponse
            CreateMap<Resturant, UpdateRestaurantRespone>();
           
            

            // from model to ModelDetailResponse
            CreateMap<Resturant, RestaurantDetalResponse>();

            // from modelList to modelListResponse

            CreateMap<Resturant, RestaurantListQueryResponse>();

        }


    }
}
