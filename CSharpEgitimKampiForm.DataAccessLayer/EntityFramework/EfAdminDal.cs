using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEgitimKampiForm.DataAccessLayer.Abstract;
using CSharpEgitimKampiForm.DataAccessLayer.Repositories;
using CSharpEgitimKampiForm.EntityLayer.Concrete;

namespace CSharpEgitimKampiForm.DataAccessLayer.EntityFramework
{
    public class EfAdminDal:GenericRepository<Admin>, IAdminDal // generic repositoryden miras alır ve IAdminDal arayüzünü uygular böylelikle entitye özgü işlemler yapabiliriz mesela ekle sil güncelle listele ve ıdye göre getir bunlar genel işlemlerdir ama örnek vermek gerekirs eiçinde a harfi geçmeyen kullanıcıları listele gibi özgü işlemler yaparız
    {

    }
}
