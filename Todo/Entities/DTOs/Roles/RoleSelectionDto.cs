using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Roles
{
    public class RoleSelectionDto : IDto
    {
        public List<Role> RolesOfUser { get; set; }
        public List<Role> RoleList { get; set; }

        public RoleSelectionDto()
        {
            RolesOfUser = new List<Role>();
            RoleList = new List<Role>();
        }

    }
}
