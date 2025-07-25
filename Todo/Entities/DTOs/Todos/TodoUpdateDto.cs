using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Todos
{
    public class TodoUpdateDto:IDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Status { get; set; } // Todo = 1 , InProgress = 2 , Done = 3
        public int AssignedUserId { get; set; }
    }
}
