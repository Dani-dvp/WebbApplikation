using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using RestaurantReview.Domain.IRepositories;

namespace RestaurantReview.Application.Features.Categories.Commands.CreateCategory
{
   public class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
    {
        private readonly ICategoryRepository _categoryRepository;
    
        public CreateCategoryCommandValidator(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;

            RuleFor(p => p.RestaurantCategory)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.")
                .MinimumLength(3).WithMessage("{PropertyName} must contain at least 3 characters.");

           

            RuleFor(e => e)
                 .MustAsync(IsCategoryUnique)
                 .WithMessage("A Category with the same name already exists.");

        }
        private async Task<bool> IsCategoryUnique(CreateCategoryCommand e, CancellationToken token)
        {
            return  !(await _categoryRepository.IsCategoryUnique(e.RestaurantCategory));
        }
    }
}