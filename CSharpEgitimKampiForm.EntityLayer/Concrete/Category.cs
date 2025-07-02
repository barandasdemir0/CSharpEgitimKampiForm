using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampiForm.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
    }
}
//internal sadece o katman
//public ise her yerden erişilebilir
//protected ise sadece miras alan sınıflar erişebilir
//private ise sadece o sınıf erişebilir


//field  int = x; yani classın içine direkt atanırsa field olur
//property public int X { get; set; } classın içine get ve set ile tanımlanırsa property olur
// variable void test() {  int z ; } // yani methodun içine tanımlanırsa variable olur

// get: Bir property'sinin değerini dışarıya döndürmek (almak) için kullanılır.
// set: Dışarıdan gelen değeri property'se atamak (değerini ayarlamak) için kullanılır.
//get { return name; }   // "get" ile name değerini alıyoruz.
//set { name = value; }  // "set" ile dışarıdan gelen değeri name'e atıyoruz.