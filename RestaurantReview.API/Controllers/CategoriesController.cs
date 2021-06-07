using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestaurantReview.Application.Features.Categories.Commands.AddRestaurantToCategory;
using RestaurantReview.Application.Features.Categories.Commands.CreateCategory;
using RestaurantReview.Application.Features.Categories.Commands.DeleteCategory;
using RestaurantReview.Application.Features.Categories.Commands.UpdateCategory;
using RestaurantReview.Application.Features.Categories.Queries.GetCategoryByNameQuery;
using RestaurantReview.Application.Features.Categories.Queries.GetCategoryListQuery;
using RestaurantReview.Application.Features.Categories.Queries.GetCategoryQuery;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantReview.API.Controllers
{

    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICreateCategoryService _createCategoryService;
        private readonly IDeleteCategoryService _deleteCategoryService;
        private readonly IUpdateCategoryService _updateCategoryService;
        private readonly ICategoryListQueryService _categoryListQueryService;
        private readonly ICategoryDetailQueryService _categoryDetailQueryService;
        private readonly IAddRestaurantToCategoryService _addRestaurantToCategoryService;
        private readonly IGetCategoryByNameService _getCategoryByNameService;




        public CategoriesController
            (ICreateCategoryService createCategoryService, IDeleteCategoryService deleteCategoryService
            , IUpdateCategoryService updateCategoryService, ICategoryListQueryService categoryListQueryService
            , ICategoryDetailQueryService categoryDetailQueryService
            , IAddRestaurantToCategoryService addRestaurantToCategoryService, IGetCategoryByNameService getCategoryByNameService)


        {
            _createCategoryService = createCategoryService;
            _deleteCategoryService = deleteCategoryService;
            _updateCategoryService = updateCategoryService;
            _categoryListQueryService = categoryListQueryService;
            _categoryDetailQueryService = categoryDetailQueryService;
            _addRestaurantToCategoryService = addRestaurantToCategoryService;
            _getCategoryByNameService = getCategoryByNameService;
        }


        [Authorize]
        [HttpPost]
        public async Task<ActionResult<CreateCategoryResponse>> CreateCategory(CreateCategoryCommand createCategoryCommand)
        {
            var response = await _createCategoryService.CreateCategory(createCategoryCommand);
            if (response.Success == false)
            {
                return BadRequest();
            }

            return Ok(response);

        }

        [Authorize]
        [HttpDelete]
        public async Task<string> DeleteCategory(DeleteCategoryCommand deleteCategoryCommand)
        {
            return await _deleteCategoryService.DeleteCategory(deleteCategoryCommand);
        }

        [Authorize]
        [HttpPut]
        public async Task<ActionResult<UpdateCategoryResponse>> UpdateCategory(UpdateCategoryCommand updateCategoryCommand)
        {
            var response = await _updateCategoryService.UpdateCategory(updateCategoryCommand);

            if (response.Success == false)
            {
                return BadRequest(response);
            }
            else
            {
                return Ok(response);
            }

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
        [HttpPost("addRestaurant")]
        public async Task<ActionResult<AddRestaurantToCategoryResponse>> AddRestaurantToCategory([FromBody] AddRestaurantToCategoryCommand addRestaurantToCategoryCommand)
        {
            var response = await _addRestaurantToCategoryService.AddRestaurantToCategory(addRestaurantToCategoryCommand);

            if (response.Success == false)
            {
                return BadRequest(response);
            }
            else
            {
                return Ok(response);
            }

        }


        [HttpGet("name/{categoryname}")]
        public async Task<GetCategoryByNameResponse> GetCategoryByName([FromRoute] string categoryname)
        {
            return await _getCategoryByNameService.GetCategoryByName(categoryname);
        }




    }

}
