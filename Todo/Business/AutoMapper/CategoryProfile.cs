using AutoMapper;
using Entities.Concrete;
using Entities.DTOs.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.AutoMapper
{
    public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryAddDto,Category>();
            CreateMap<CategoryUpdateDto,Category>().
                     ForMember(dest=>dest.CreatedAt,opt=>opt.Ignore());
        }
    }
}
