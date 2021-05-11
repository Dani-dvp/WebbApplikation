using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestaurantReview.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Categories.Queries.GetCategoryQuery
{
 public class CategoryDetailQueryHandler : ICategoryDetailQueryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryDetailQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<CategoryDetailQueryResponse> GetCategoryByID  (CategoryDetailQueryCommand categoryDetailQueryCommand)
        {

            var getCategoryByID = await _categoryRepository.GetByIdAsync(categoryDetailQueryCommand.CategoryID);
            var GetCategoryResponse = _mapper.Map<CategoryDetailQueryResponse>(getCategoryByID);

            return GetCategoryResponse;
        }
    }
}
