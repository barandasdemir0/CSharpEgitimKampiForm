using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampiForm.EFProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {

            var values = db.Guides.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide();
            guide.GuideName = txtName.Text;
            guide.GuideSurname = txtSurname.Text;
            db.Guides.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Başarıyla Eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var removeValue = db.Guides.Find(id);
            db.Guides.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Başarıyla Silindi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updateValue = db.Guides.Find(id);
            updateValue.GuideName = txtName.Text;
            updateValue.GuideSurname = txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Başarıyla Güncellendi");

        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = db.Guides.Where(x => x.GuideId == id).ToList();
            dataGridView1.DataSource = value;
            
           
        }
    }
}
