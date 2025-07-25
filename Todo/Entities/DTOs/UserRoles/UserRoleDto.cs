using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.UserRoles
{
    public class UserRoleDto:IDto
    {
        public int RoleId { get; set; }
    }
}
