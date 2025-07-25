using AutoMapper;
using Core.Entities.Concrete;
using Entities.DTOs.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.AutoMapper
{
    public class RoleProfile:Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleAddDto,Role>();
            CreateMap<RoleUpdateDto,Role>()
                 .ForMember(dest=>dest.CreatedAt,opt=>opt.Ignore());
        }
    }
}
