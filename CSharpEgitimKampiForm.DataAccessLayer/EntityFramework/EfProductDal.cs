using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEgitimKampiForm.DataAccessLayer.Abstract;
using CSharpEgitimKampiForm.DataAccessLayer.Context;
using CSharpEgitimKampiForm.DataAccessLayer.Repositories;
using CSharpEgitimKampiForm.EntityLayer.Concrete;

namespace CSharpEgitimKampiForm.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Object> GetProductsWithCategory()
        {
            var context = new KampContext();
            var values = context.Products.Select(x => new 
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                ProductStock = x.ProductStock,
                ProductPrice = x.ProductPrice,
                ProductDescription = x.ProductDescription,
                CategoryName = x.Category.CategoryName
            }).ToList(); // Products tablosundan Category ile birlikte ürünleri alıyoruz. CategoryName'i de dahil ediyoruz. ve toList() ile listeye çeviriyoruz.
            return values.Cast<object>().ToList();


        }
    }
}
