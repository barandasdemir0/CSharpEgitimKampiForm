using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpEgitimKampiForm.BusinessLayer.Abstract;
using CSharpEgitimKampiForm.BusinessLayer.Concrete;
using CSharpEgitimKampiForm.DataAccessLayer.Abstract;
using CSharpEgitimKampiForm.DataAccessLayer.EntityFramework;
using CSharpEgitimKampiForm.EntityLayer.Concrete;

namespace CSharpEgitimKampiForm.PresentationLayer
{
    public partial class FrmCategory : Form
    {

        private readonly ICategoryService _categoryService; // dependecy injection kullanarak service'i alıyoruz

        public FrmCategory() 
        {
            _categoryService = new CategoryManager(new EfCategoryDal()); // EfCategoryDal ile CategoryManager'ı başlatıyoruz
            InitializeComponent();
        }

        


        private void btnList_Click(object sender, EventArgs e)
        {
            var  categoryValues = _categoryService.TGetAll(); 
            dataGridView1.DataSource = categoryValues; // service'den gelen veriyi grid'e atıyoruz
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category(); // yeni bir kategori nesnesi oluşturuyoruz ama neden bunu yapıyoruz? // çünkü Entity Framework ile çalışırken veriyi bu nesne üzerinden ekleyeceğiz
            category.CategoryName = txtAd.Text; // textbox'tan gelen değeri category nesnesine atıyoruz
            category.CategoryStatus = true; // kategori durumu aktif olarak ayarlıyoruz
            _categoryService.TInsert(category); // service üzerinden ekleme işlemi yapıyoruz
            MessageBox.Show("Kategori Eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text); // silinecek kategori id'sini textbox'tan alıyoruz
            var deletedValue = _categoryService.TGetById(id);
            _categoryService.TDelete(deletedValue);
            MessageBox.Show("Kategori Silindi");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var getByid = _categoryService.TGetById(id);
            dataGridView1.DataSource = getByid;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          
            int updatedId = int.Parse(txtId.Text);
            var value = _categoryService.TGetById(updatedId);
            value.CategoryName = txtAd.Text;
            value.CategoryStatus = true;
            _categoryService.TUpdate(value);
        }
    }
}
