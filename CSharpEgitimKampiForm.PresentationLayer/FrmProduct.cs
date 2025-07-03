using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class FrmProduct : Form
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;
        public FrmProduct()
        {
            InitializeComponent();
            productService = new ProductManager(new EfProductDal());
            categoryService = new CategoryManager(new EfCategoryDal());
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values = categoryService.TGetAll(); // CategoryManager sınıfının TGetAll metodu ile tüm kategorileri alıyoruz.
            cmbCategory.DataSource = values; // Alınan kategorileri cmbCategory'e atıyoruz.
            cmbCategory.DisplayMember = "CategoryName"; // cmbCategory'in görüntülenecek özelliğini CategoryName olarak ayarlıyoruz.
            cmbCategory.ValueMember = "CategoryId"; // cmbCategory'in değerini CategoryId olarak ayarlıyoruz.

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = productService.TGetAll(); // ProductManager sınıfının TGetAll metodu ile tüm ürünleri alıyoruz.
            dataGridView1.DataSource = values; // Alınan ürünleri dataGridView1'e atıyoruz.
        }

        private void btn_List2_Click(object sender, EventArgs e)
        {
            var values = productService.GetProductsWithCategory(); // ProductManager sınıfının GetProductsWithCategory metodu ile kategori ile birlikte tüm ürünleri alıyoruz.
            dataGridView1.DataSource = values; // Alınan ürünleri dataGridView1'e atıyoruz.
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text); // TextBox1'den alınan id değerini int'e çeviriyoruz.
            var deletedValues = productService.TGetById(id);
            productService.TDelete(deletedValues);
            MessageBox.Show("silme başarılı");


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            product.ProductPrice = int.Parse(txtPrice.Text);
            product.ProductStock = int.Parse(txtStock.Text);
            product.ProductName = txtAd.Text;
            product.ProductDescription = txtExplained.Text;
            productService.TInsert(product);
            MessageBox.Show("veriler başarılı bir şekilde eklendi");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
             
            var product = new Product();
            int id = Convert.ToInt32(txtId.Text); // TextBox1'den alınan id değerini int'e çeviriyoruz.
            product = productService.TGetById(id); // ProductManager sınıfının TGetById metodu ile id'ye göre ürünü alıyoruz.
            dataGridView1.DataSource = new List<Product> { product }; // Alınan ürünü dataGridView1'e atıyoruz.

            MessageBox.Show("veriler başarılı bir şekilde getirildi");



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            var values = productService.TGetById(id);
            values.ProductName = txtAd.Text;
            values.ProductStock = int.Parse(txtStock.Text);
            values.ProductPrice = int.Parse(txtPrice.Text);
            values.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            values.ProductDescription = txtExplained.Text;
            productService.TUpdate(values);
            MessageBox.Show("güncelleme başarılı");
        }
    }
}



