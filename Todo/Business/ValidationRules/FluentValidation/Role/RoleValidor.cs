using Core.Entities;
using Entities.DTOs.Roles;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation.Role
{
    public class RoleValidor : AbstractValidator<RoleAddDto>
    {
        public RoleValidor()
        {
            RuleFor(r => r.RoleName).NotEmpty();
            RuleFor(r => r.Description).NotEmpty();
        }

    }
}
