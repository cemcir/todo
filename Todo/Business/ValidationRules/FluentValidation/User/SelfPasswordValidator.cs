using Entities.DTOs.Users;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation.User
{
    public class SelfPasswordValidator:AbstractValidator<SelfPasswordDto>
    {
        public SelfPasswordValidator() 
        {
            RuleFor(sp => sp.OldPassword).NotEmpty();
            RuleFor(sp => sp.NewPassword).NotEmpty();
            RuleFor(sp => sp.RepeatNewPassword).NotEmpty();
            RuleFor(sp => sp.OldPassword).MinimumLength(8);
            RuleFor(sp => sp.NewPassword).MinimumLength(8);
            RuleFor(sp => sp.RepeatNewPassword).MinimumLength(8);
            RuleFor(sp => sp.NewPassword).Equal(sp => sp.RepeatNewPassword); 
        }
    }
}


// public class UserAddDto:IDto {
//      public string UserName { get;set;}
//      public string Email { get;set;}
//      public string Password { get;set;}
//
//      public List<UserRoleDto>? UserRoles {get;set;}
// }

// public class UserRoleDto:IDto {
//      public int RoleId { get;set;}
// }


// public class UserProfile:Profile {
//      
//      public UserProfile() {
//          CreateMap<UserAddDto,User>();    
//      }
// }

// public class UserRoleProfile:Profile {
//      
//     public UserRoleProfile() {
//          CreateMap<UserRoleDto,UserRole>();
//     }    
// }  