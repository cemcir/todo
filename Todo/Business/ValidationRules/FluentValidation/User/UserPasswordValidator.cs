using Entities.DTOs.Users;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation.User
{
    public class UserPasswordValidator : AbstractValidator<UserPasswordDto>
    {
        public UserPasswordValidator()
        {
            RuleFor(up => up.UserId).NotEmpty();
            RuleFor(up => up.Password).NotEmpty();
            RuleFor(up => up.Password).MinimumLength(8);
            RuleFor(up => up.RepeatPassword).NotEmpty();
            RuleFor(up => up.RepeatPassword).MinimumLength(8);
            RuleFor(up => up.RepeatPassword).Equal(up => up.Password);
        }
    }
}

// $userPasswordValidator = []