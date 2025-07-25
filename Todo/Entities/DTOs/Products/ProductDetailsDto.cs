using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Products
{
    public class ProductDetailsDto : IDto
    {
        public Product? Product { get; set; }
        public List<Category> Categories { get; set; }

        public ProductDetailsDto(Product? product, List<Category> categories)
        {
            Product = product;
            Categories = categories;
        }

    }
}
