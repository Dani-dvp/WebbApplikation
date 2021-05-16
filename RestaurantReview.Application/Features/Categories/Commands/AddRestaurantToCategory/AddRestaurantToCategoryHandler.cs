using AutoMapper;
using RestaurantReview.Domain.IRepositories;
using RestaurantReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Categories.Commands.AddRestaurantToCategory
{
    public class AddRestaurantToCategoryHandler : IAddRestaurantToCategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IMapper _mapper;

        public AddRestaurantToCategoryHandler(IMapper mapper, ICategoryRepository categoryRepository, IRestaurantRepository restaurantRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
            _restaurantRepository = restaurantRepository;
        }

        public async Task<AddRestaurantToCategoryResponse> AddRestaurantToCategory(AddRestaurantToCategoryCommand addRestaurantToCategoryCommand)
        {
            var restaurantToBeAdded = await _restaurantRepository.GetRestaurantByName(addRestaurantToCategoryCommand.RestaurantName);

            var categoryToBeupdated = await _categoryRepository.GetCategoryByName(addRestaurantToCategoryCommand.CategoryName);

            //if(categoryToBeupdated.Restaurants == null)
            //{
            //    categoryToBeupdated.Restaurants = new List<Restaurant>();
            //}

            categoryToBeupdated.Restaurants.Add(restaurantToBeAdded);

            await _categoryRepository.UpdateAsync(categoryToBeupdated);

            var categoryResponse = _mapper.Map<AddRestaurantToCategoryResponse>(categoryToBeupdated);

            return categoryResponse;
        }

    }
}
