using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestaurantReview.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Categories.Queries.GetCategoryListQuery
{
   public  class CategoryListQueryHandler : ICategoryListQueryService
    {

        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryListQueryHandler(ICategoryRepository categoryRepository , IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<List<CategoryListQueryResponse>> GetCategoryList()
        {
          var listAllCategories = await _categoryRepository.ListAllAsync();
          var categoryResponse =  _mapper.Map<List<CategoryListQueryResponse>>(listAllCategories);

            return categoryResponse;
        }
    }
}
