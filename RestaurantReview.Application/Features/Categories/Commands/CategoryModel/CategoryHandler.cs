using AutoMapper;
using RestaurantReview.Application.Features.Reviews.Commands.ReviewModel;
using RestaurantReview.Domain.IRepositories;
using RestaurantReview.Domain.Models;
using System;
using System.Threading.Tasks;


namespace RestaurantReview.Application.Features.Categories.Commands.CategoryModel
{
    public class CategoryHandler : ICategoryService
    {

        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;


        public CategoryHandler(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;



        }

        public async Task<Action> Category( )
        {
            return null;
        }
    }
}
