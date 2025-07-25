using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Roles
{
    public class RoleAddDto : IDto
    {
        public string RoleName { get; set; }
        public string Description { get; set; }
    }
}
