using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEgitimKampiForm.EntityLayer.Concrete;

namespace CSharpEgitimKampiForm.DataAccessLayer.Abstract
{
    public interface IOrderDal: IGenericDal<Order> // Order sınıfından nesneler alır
    {
    }
}
