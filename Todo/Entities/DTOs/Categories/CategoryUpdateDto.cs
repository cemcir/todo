﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Categories
{
    public class CategoryUpdateDto : IDto
    {
        public long CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
