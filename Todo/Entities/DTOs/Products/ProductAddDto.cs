using Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Products
{
    public class ProductAddDto : IDto
    {

        public string ProductName { get; set; }

        public string BarcodeNo { get; set; }
        public IFormFile? Image { get; set; }
        public decimal SalePrice { get; set; }
        public decimal PurchasePrice { get; set; }
        public string Unit { get; set; }
        public int Kdv { get; set; }
        public int StockPiece { get; set; }
        public int SaleState { get; set; }
        public int? CategoryId { get; set; }
    }
}
