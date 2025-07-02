using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEgitimKampiForm.EntityLayer.Concrete;

namespace CSharpEgitimKampiForm.DataAccessLayer.Abstract
{
    public interface IAdminDal:IGenericDal<Admin> // Admin sınıfından nesneler alır
    {
    }
}
