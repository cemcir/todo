using AutoMapper;
using Entities.Concrete;
using Entities.DTOs.Todos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.AutoMapper
{
    public class TodoProfile:Profile
    {
        public TodoProfile()
        {
            CreateMap<TodoAddDto,Todo>();
            CreateMap<TodoUpdateDto,Todo>(). 
                ForMember(dest=>dest.CreatedAt,opt=>opt.Ignore());
        }
    }
}
