using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEgitimKampiForm.BusinessLayer.Abstract;
using CSharpEgitimKampiForm.DataAccessLayer.Abstract;
using CSharpEgitimKampiForm.EntityLayer.Concrete;

namespace CSharpEgitimKampiForm.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;// Dependency injection ile productdal'ı alıyorum
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal; // ProductDal'ı constructor ile alıyorum
        }// burada productdal'ı alıyorum ve bu productdal'ı kullanarak işlemlerimi yapacağım

        public List<object> GetProductsWithCategory()
        {
            return _productDal.GetProductsWithCategory(); // ProductDal'daki GetProductsWithCategory metodunu çağırıyorum ve kategori ile birlikte ürünleri getiriyorum
        }

        public void TDelete(Product entity)
        {
            _productDal.Delete(entity); // ProductDal'daki delete metodunu çağırıyorum ve silme işlemi yapıyorum
        }

        public List<Product> TGetAll()
        {
            return _productDal.GetAll();// ProductDal'daki GetAll metodunu çağırıyorum ve tüm ürünleri getiriyorum
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id); // ProductDal'daki GetById metodunu çağırıyorum ve id'ye göre ürünü getiriyorum
        }

        public void TInsert(Product entity)
        {
            _productDal.Insert(entity); // ProductDal'daki Insert metodunu çağırıyorum ve ekleme işlemi yapıyorum
        }

        public void TUpdate(Product entity)
        {
            _productDal.Update(entity); // ProductDal'daki Update metodunu çağırıyorum ve güncelleme işlemi yapıyorum
        }
    }
}
