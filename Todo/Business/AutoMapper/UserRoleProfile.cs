using AutoMapper;
using Core.Entities.Concrete;
using Entities.DTOs.UserRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.AutoMapper
{
    public class UserRoleProfile:Profile
    {
        public UserRoleProfile()
        {
            CreateMap<UserRoleDto,UserRole>();
        }
    }
}
