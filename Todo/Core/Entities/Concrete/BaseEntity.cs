﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class BaseEntity : IEntity
    {
        public DateTime? CreatedAt { get ; set ; }
        public DateTime? UpdatedAt { get ; set ; }
        public bool IsDeleted { get ; set ; }
    }
}
