using Microsoft.AspNetCore.Mvc;
using RestaurantReview.Application.Features.Categories.Commands.CreateCategory;
using RestaurantReview.Application.Features.Categories.Commands.DeleteCategory;
using RestaurantReview.Application.Features.Categories.Commands.UpdateCategory;
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



        public CategoriesController
            (ICreateCategoryService createCategoryService, IDeleteCategoryService deleteCategoryService
            , IUpdateCategoryService updateCategoryService, ICategoryListQueryService categoryListQueryService
            , ICategoryDetailQueryService categoryDetailQueryService
            )


        {
            _createCategoryService = createCategoryService;
            _deleteCategoryService = deleteCategoryService;
            _updateCategoryService = updateCategoryService;
            _categoryListQueryService = categoryListQueryService;
            _categoryDetailQueryService = categoryDetailQueryService;
        }

        [HttpPost]


        public async Task<ActionResult<CreateCategoryResponse>> CreateCategoryController(CreateCategoryCommand createCategoryCommand)
        {
            return Ok(await _createCategoryService.CreateCategory(createCategoryCommand));


        }


        [HttpDelete]

        public async Task<string> DeleteCategoryController(DeleteCategoryCommand deleteCategoryCommand)
        {
            return await _deleteCategoryService.DeleteCategory(deleteCategoryCommand);
        }


        [HttpPut]

        public async Task<UpdateCategoryResponse> UpdateCategoryController(UpdateCategoryCommand updateCategoryCommand)
        {
            return await _updateCategoryService.UpdateCategory(updateCategoryCommand);
        }



        [HttpGet]

        public async Task<List<CategoryListQueryResponse>> GetCategoryListController()
        {
            return await _categoryListQueryService.GetCategoryList();
        }

        [HttpGet("{CategoryID}")]
        public async Task<CategoryDetailQueryResponse> GetCategoryController([FromQuery] CategoryDetailQueryCommand categoryDetailQueryCommand)
        {
            return await _categoryDetailQueryService.GetCategoryByID(categoryDetailQueryCommand);
        }



    }

}
