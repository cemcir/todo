using Entities.DTOs.Customers;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation.Category
{
    public class CategoryDeleteValidator:AbstractValidator<CategoryDeleteDto>
    {
        public CategoryDeleteValidator()
        {
            RuleFor(c => c.CategoryId).NotEmpty();
        }
    }
}
