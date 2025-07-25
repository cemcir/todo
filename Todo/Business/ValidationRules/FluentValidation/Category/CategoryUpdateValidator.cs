using Entities.DTOs.Categories;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation.Category
{
    public class CategoryUpdateValidator:AbstractValidator<CategoryUpdateDto>
    {
        public CategoryUpdateValidator()
        {
            RuleFor(x => x.CategoryId).NotEmpty();
            RuleFor(x => x.CategoryName).NotEmpty();
        }
    }
}
