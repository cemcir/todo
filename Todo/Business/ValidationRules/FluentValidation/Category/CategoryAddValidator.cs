using Entities.DTOs.Categories;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation.Category
{
    public class CategoryAddValidator:AbstractValidator<CategoryAddDto>
    {
        public CategoryAddValidator()
        {
            RuleFor(c => c.CategoryName).NotEmpty();
            //['CategoryName'=>'required'];
        }
    }
}
