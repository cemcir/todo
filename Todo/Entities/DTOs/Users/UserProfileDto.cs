using Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Users
{
    public class UserProfileDto:IDto
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public IFormFile? Image { get; set; }
    }
}
