using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampiForm.EntityLayer.Concrete
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; } // Product sınıfı ile ilişki kuruyoruz. virtual keywordü ile lazy loading yapıyoruz.
        public int Quantity { get; set; } // Sipariş miktarı
        public decimal UnitPrice { get; set; }// Siparişin birim fiyatı
        public decimal TotalPrice { get;set; } // Toplam sipariş fiyatı
        public int CustomerId { get; set; } // Siparişi veren müşteri
        public virtual Customer Customer { get; set; } // Customer sınıfı ile ilişki kuruyoruz. virtual keywordü ile lazy loading yapıyoruz.

    }
}
