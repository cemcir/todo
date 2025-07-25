using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Customers
{
    public class CategorySalesSummaryDto
    {
        public string CategoryName { get; set; } // Kategori İsmi
        public int TotalQuantity { get; set; } // Herbir Kategoriye Ait Satış Sayısı
        public decimal TotalSales { get; set; } // Kategori Satışına Ait Toplam Tutar
    }
}
