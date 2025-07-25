using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Todos
{
    public class TodoAddDto:IDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public int AssignedUserId { get; set; }
    }
}
