using Entities.DTOs.Products;
using Entities.DTOs.Users;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation.User
{
    public class UserValidator : AbstractValidator<UserAddDto>
    {
        public UserValidator()
        {
            RuleFor(u => u.Name).NotEmpty();
            RuleFor(u => u.Email).NotEmpty();
            RuleFor(u => u.Password).NotEmpty();   
        }
    }
}
