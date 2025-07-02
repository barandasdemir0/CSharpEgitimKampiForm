using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampiForm.EntityLayer.Concrete
{
    public class Admin
    {
        public int AdminId { get; set; } //veritabanında primary key olacak alan
        public string UserName { get; set; } //adminin adı
        public string Password { get; set; } //adminin şifresi
      
    }
}
