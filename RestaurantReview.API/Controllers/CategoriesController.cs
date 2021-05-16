﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestaurantReview.Application.Features.Categories.Commands.AddRestaurantToCategory;
using RestaurantReview.Application.Features.Categories.Commands.CreateCategory;
using RestaurantReview.Application.Features.Categories.Commands.DeleteCategory;
using RestaurantReview.Application.Features.Categories.Commands.UpdateCategory;
using RestaurantReview.Application.Features.Categories.Queries.GetAllRestaurantsFromCategoryByNameQuery;
using RestaurantReview.Application.Features.Categories.Queries.GetCategoryListQuery;
using RestaurantReview.Application.Features.Categories.Queries.GetCategoryQuery;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantReview.API.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICreateCategoryService _createCategoryService;
        private readonly IDeleteCategoryService _deleteCategoryService;
        private readonly IUpdateCategoryService _updateCategoryService;
        private readonly ICategoryListQueryService _categoryListQueryService;
        private readonly ICategoryDetailQueryService _categoryDetailQueryService;
        private readonly IAddRestaurantToCategoryService _addRestaurantToCategoryService;
        private readonly IGetAllRestaurantsFromCategoryByNameService _getAllRestaurantsFromCategoryByNameService;



        public CategoriesController
            (ICreateCategoryService createCategoryService, IDeleteCategoryService deleteCategoryService
            , IUpdateCategoryService updateCategoryService, ICategoryListQueryService categoryListQueryService
            , ICategoryDetailQueryService categoryDetailQueryService
            , IAddRestaurantToCategoryService addRestaurantToCategoryService, IGetAllRestaurantsFromCategoryByNameService getAllRestaurantsFromCategoryByNameService)


        {
            _createCategoryService = createCategoryService;
            _deleteCategoryService = deleteCategoryService;
            _updateCategoryService = updateCategoryService;
            _categoryListQueryService = categoryListQueryService;
            _categoryDetailQueryService = categoryDetailQueryService;
            _addRestaurantToCategoryService = addRestaurantToCategoryService;
            _getAllRestaurantsFromCategoryByNameService = getAllRestaurantsFromCategoryByNameService;
        }


        [Authorize]
        [HttpPost]
        public async Task<ActionResult<CreateCategoryResponse>> CreateCategory(CreateCategoryCommand createCategoryCommand)
        {
            return Ok(await _createCategoryService.CreateCategory(createCategoryCommand));


        }

        [Authorize]
        [HttpDelete]
        public async Task<string> DeleteCategory(DeleteCategoryCommand deleteCategoryCommand)
        {
            return await _deleteCategoryService.DeleteCategory(deleteCategoryCommand);
        }

        [Authorize]
        [HttpPut]
        public async Task<UpdateCategoryResponse> UpdateCategory(UpdateCategoryCommand updateCategoryCommand)
        {
            return await _updateCategoryService.UpdateCategory(updateCategoryCommand);
        }



        [HttpGet]
        public async Task<List<CategoryListQueryResponse>> GetCategoryList()
        {
            return await _categoryListQueryService.GetCategoryList();
        }

        [HttpGet("{CategoryID}")]
        public async Task<CategoryDetailQueryResponse> GetCategory([FromQuery] CategoryDetailQueryCommand categoryDetailQueryCommand)
        {
            return await _categoryDetailQueryService.GetCategoryByID(categoryDetailQueryCommand);
        }

        [Authorize]
        [HttpPut("restaurant")]
        public async Task<AddRestaurantToCategoryResponse> AddRestaurantToCategory(AddRestaurantToCategoryCommand addRestaurantToCategoryCommand)
        {
            return await _addRestaurantToCategoryService.AddRestaurantToCategory(addRestaurantToCategoryCommand);
        }

        [HttpGet("restaurant/{CategoryName}")]
        public async Task<GetAllRestaurantsFromCategoryByNameResponse> GetAllRestaurantsFromCategoryByName(string categoryName)
        {
            // Inte klar ännu får fortsätta senare, lägger samma kommentar i controllern
            return await _getAllRestaurantsFromCategoryByNameService.GetAllRestaurantsFromCategoryByName(categoryName);
        }


    }

}
