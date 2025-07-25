using AutoMapper;
using Core.Entities.Concrete;
using Entities.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.AutoMapper
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<UserAddDto, User>(); 

            CreateMap<UserUpdateDto, User>().
                ForMember(dest => dest.CreatedAt, opt => opt.Ignore()).
                ForMember(dest => dest.PasswordHash, opt => opt.Ignore());
               // ForMember(dest=>dest.LastLoginDate,opt=>opt.Ignore()).
                //ForMember(dest=>dest.Image,opt=>opt.Ignore());

            /*
            CreateMap<UserProfileDto,User>().
                ForMember(dest => dest.CreatedAt, opt => opt.Ignore()).
                ForMember(dest => dest.LastLoginDate, opt => opt.Ignore()).
                ForMember(dest => dest.IsActive, opt => opt.Ignore()).
                ForMember(dest => dest.Image, opt => opt.Ignore()).
                ForMember(dest => dest.PasswordHash, opt => opt.Ignore());
            */

        }
    }
}
