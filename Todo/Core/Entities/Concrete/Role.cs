using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class Role:BaseEntity
    {
        public Role()
        {
            UserRoles = new List<UserRole>();
        }

        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public List<UserRole> UserRoles { get; set; }
    }
}
