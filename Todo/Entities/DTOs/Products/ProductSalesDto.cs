using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Products
{
    public class ProductSalesDto:IDto
    {
        public long DetailId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string ProductName { get; set; }
        public string BarcodeNo { get; set; }
    }

}
