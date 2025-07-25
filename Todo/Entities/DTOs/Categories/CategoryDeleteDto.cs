using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Customers
{
    public class CategoryDeleteDto : IDto
    {
        public long CategoryId { get; set; }
    }

}
