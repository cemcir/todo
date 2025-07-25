using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Products
{
    public class ProductListDto
    {
        public List<Product> Products { get; set; }
        public int TotalRecord { get; set; }

        public ProductListDto()
        {
            Products = new List<Product>();
            TotalRecord = 0;
        }

        public ProductListDto(List<Product> products, int totalRecord)
        {
            Products = products;
            TotalRecord = totalRecord;
        }

    }
}
