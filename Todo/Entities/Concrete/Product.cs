using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class Product :BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public string BarcodeNo { get; set; }
        public string? Image { get; set; }
        public decimal SalePrice { get; set; } = 0; // kdv dahil fiyat
        public decimal PurchasePrice { get; set; } = 0;
        public string Unit { get; set; }
        public int Kdv { get; set; }
        public int StockPiece { get; set; } = 0;
        public int SaleState { get; set; } = 1;
        public long? CategoryId { get; set; }
        public Category Category { get; set; } // Bir Ürüne Air Bir Kategori Var
        public int UserId { get; set; }
        public User User { get; set; }
    }
}

