using Entities.Concrete;
using Entities.DTOs.Products;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation.Product
{
    public class ProductValidator : AbstractValidator<ProductAddDto>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty(); // Ürün İsmi Boş Olamaz
            RuleFor(p => p.ProductName).MinimumLength(2); // Ürün İsmi Minimum 2 Karakter Olmalı
            RuleFor(p => p.SalePrice).NotEmpty(); // Ürün Satış Fiyatı Boş Olamaz
            RuleFor(p => p.SalePrice).GreaterThan(0); // Ürün Satış Fiyatı Sıfırdan Büyük Olmalı
            RuleFor(p => p.PurchasePrice).NotEmpty(); // Ürün Alış Fiyatı Boş Olamaz
            RuleFor(p => p.PurchasePrice).GreaterThan(0); // Ürün Alış Fiyatı Sıfırdan Büyük Olmalı
            //RuleFor(p => p.ProductName).Must(StartWithA); // Ürünlerin İsmi A ile Başlamalı
            //RuleFor(p => p.PurchasePrice).GreaterThanOrEqualTo(10).When(p=>p.CategoryId==1); // Ürün Kategorisi İçecekse 10 a Eşit ve Büyük Olmalı
        }

        private bool StartWithA(string arg) // A Harfi İle Başlayan Ürünler
        {
            return arg.ToLower().StartsWith("A");
        }
    }
}
