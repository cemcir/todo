using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Products
{
    public class ProductPurchaseDto : IDto
    {
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }
    }
}
