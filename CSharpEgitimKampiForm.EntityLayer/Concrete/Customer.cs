using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampiForm.EntityLayer.Concrete
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerDistrict { get; set; }    
        public string CustomerCity { get; set; }
        public List<Order> Orders { get; set; } // Customer sınıfı ile ilişki kuruyoruz. Customer'ın birden fazla siparişi olabilir.
        public bool CustomerStatus { get; set; } // Müşteri aktif mi pasif mi? Bunu tutuyoruz.
    }
}

