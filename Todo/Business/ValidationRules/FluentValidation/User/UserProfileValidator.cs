using Entities.DTOs.Users;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation.User
{
    public class UserProfileValidator:AbstractValidator<UserProfileDto>
    {
        public UserProfileValidator()
        {
            RuleFor(up => up.Email).NotEmpty();
            RuleFor(up => up.Phone).NotEmpty().MaximumLength(10);
        }
    }
}
