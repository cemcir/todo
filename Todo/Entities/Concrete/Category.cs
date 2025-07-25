using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Category:BaseEntity // Ürün Kategorisi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CategoryId { get; set; }
        public string CategoryName { get; set; } // Ürün Kategori Adı
        //public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}

