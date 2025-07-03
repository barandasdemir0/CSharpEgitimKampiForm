using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using CSharpEgitimKampiForm.DataAccessLayer.Abstract;
using CSharpEgitimKampiForm.DataAccessLayer.Context;

namespace CSharpEgitimKampiForm.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {

        KampContext context = new KampContext(); // KampContext sınıfından bir nesne oluşturuyoruz. Bu nesne veritabanı işlemlerini yapmamızı sağlayacak.
        private readonly DbSet<T> _object; // DbSet<T> türünde bir nesne tanımlıyoruz. Bu nesne, veritabanındaki tablolarla etkileşimde bulunmamızı sağlayacak.

        public GenericRepository()  
        {
            _object = context.Set<T>(); // KampContext içindeki Set<T>() metodunu kullanarak, T türündeki nesnelerin veritabanındaki karşılığını alıyoruz. yani generic repository çağırıldığı zaman obje örneği oluşturuyor context tarafında gönderilen entityi yapıyor

        }
        public void Delete(T entity)
        {
            var deletedEntity = context.Entry(entity); // context üzerinden entity'nin durumunu alıyoruz.
            deletedEntity.State = EntityState.Deleted;// EntityState.Deleted ile bu nesnenin silineceğini belirtiyoruz.
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _object.ToList();// _object üzerinden ToList() metodunu çağırarak, veritabanındaki T türündeki tüm nesneleri liste olarak döndürüyoruz. 
        }


        public T GetById(int id)
        {
            return _object.Find(id); // _object üzerinden Find(id) metodunu çağırarak, verilen id'ye sahip T türündeki nesneyi buluyoruz.
        }

        public void Insert(T entity)
        {
            var addedEntity = context.Entry(entity); // context üzerinden entity'nin durumunu alıyoruz.
            addedEntity.State = EntityState.Added; // EntityState.Added ile bu nesnenin ekleneceğini belirtiyoruz.
            context.SaveChanges(); // Değişiklikleri veritabanına kaydediyoruz.

        }

        public void Update(T entity)
        {
            var updateEntity = context.Entry(entity); // context üzerinden entity'nin durumunu alıyoruz.
            updateEntity.State = EntityState.Modified; // EntityState.Modified ile bu nesnenin güncelleneceğini belirtiyoruz.
            context.SaveChanges(); // Değişiklikleri veritabanına kaydediyoruz.
        }
    }
}

