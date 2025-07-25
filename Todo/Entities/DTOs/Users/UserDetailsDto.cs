using Core.Entities;
using Core.Entities.Concrete;
using Entities.DTOs.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Users
{
    public class UserDetailsDto : IDto
    {
        public UserDto? User { get; set; }
        public List<Role> RolesOfUser { get; set; }
        public List<Role> Roles { get; set; }

        public UserDetailsDto()
        {
            RolesOfUser = new List<Role>();
            Roles = new List<Role>();
        }

    }
}
