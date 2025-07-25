using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Products
{
    public class ProductSalesCountDto:IDto
    {
        public string ProductName { get; set; }
        public int TotalSales { get; set; }
    }
}
