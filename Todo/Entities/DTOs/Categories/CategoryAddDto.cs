﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Categories
{
    public class CategoryAddDto:IDto
    {
        public string CategoryName { get; set; }
    }
}
