using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampiForm.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TInsert(T entity); // T tipinde bir nesneyi ekler
        void TUpdate(T entity); // T tipinde bir nesneyi günceller
        void TDelete(T entity); // T tipinde bir nesneyi siler
        List<T> TGetAll(); // T tipinde nesnelerin listesini döndürür
        T TGetById(int id); // T tipinde bir nesneyi id ile bulur
    }
}
