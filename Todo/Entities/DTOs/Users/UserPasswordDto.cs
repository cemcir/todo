using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Users
{
    public class UserPasswordDto:IDto
    {
        public int UserId { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
    }
}
