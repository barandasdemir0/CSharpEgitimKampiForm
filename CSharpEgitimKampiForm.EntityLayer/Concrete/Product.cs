using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEgitimKampiForm.EntityLayer.Concrete;

namespace CSharpEgitimKampiForm.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } // Category sınıfı ile ilişki kuruyoruz. virtual keywordü ile lazy loading yapıyoruz.
        public List<Order> Orders { get; set; } // Order sınıfı ile ilişki kuruyoruz. Product'ın birden fazla siparişi olabilir.
    }
}
