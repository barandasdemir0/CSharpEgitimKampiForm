using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampiForm.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class // bu sınıf sadece class türünden nesneler alabilir
    {
        
        void Insert(T entity); // T tipinde bir nesneyi ekler
        void Update(T entity); // T tipinde bir nesneyi günceller
        void Delete(int id); // T tipinde bir nesneyi siler
        List<T> GetAll(); // T tipinde nesnelerin listesini döndürür
        T GetById(int id); // T tipinde bir nesneyi id ile bulur


       
    }
}
