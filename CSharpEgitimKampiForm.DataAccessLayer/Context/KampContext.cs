using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEgitimKampiForm.EntityLayer.Concrete;

namespace CSharpEgitimKampiForm.DataAccessLayer.Context
{
    public class KampContext : DbContext //veritabaına yansıyacak herşey kampcontextin içinde yer alıyor 
    {
        public DbSet<Category> Categories { get; set; } //category C# tarafında kullanılan sınıf ismi, categories ise veritabanında kullanılacak tablo ismi

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; } //Admin sınıfı veritabanında Admin tablosuna karşılık gelecek

    }
}
