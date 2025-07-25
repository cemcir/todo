using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Todo:BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long TitleId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Status { get; set; } // 1= Todo 2 = InProgress 3 = Done
        public DateTime? DueDate { get; set; }

        [ForeignKey("AssignedUserId")]
        public User User { get; set; }
        
        public int AssignedUserId { get; set; }
    }
}
