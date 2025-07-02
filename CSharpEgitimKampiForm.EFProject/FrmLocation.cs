using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampiForm.EFProject
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities entities = new EgitimKampiEfTravelDbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = entities.Locations.ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = entities.Guides.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuideSurname,
                x.GuideId
            }).ToList();
            cmbGuide.DisplayMember = "FullName";
            cmbGuide.ValueMember = "GuideId";
            cmbGuide.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.Capacity = byte.Parse(nudQuantity.Value.ToString());
            location.City = txtCity.Text;
            location.Country = txtCountry.Text;
            location.Price = int.Parse(txtPrice.Text);
            location.DayNight = txtDayNight.Text;
            location.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            entities.Locations.Add(location);
            entities.SaveChanges();
            MessageBox.Show("başarılı");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = entities.Locations.Find(id);
            entities.Locations.Remove(value);
            entities.SaveChanges();
            MessageBox.Show("başarılı");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = entities.Locations.Find(id);
            value.Capacity = byte.Parse(nudQuantity.Value.ToString());
            value.City = txtCity.Text;
            value.Country = txtCountry.Text;
            value.Price = decimal.Parse(txtPrice.Text);
            value.DayNight = txtDayNight.Text;
            value.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            entities.SaveChanges();
            MessageBox.Show("başarılı");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = entities.Locations.Where(x => x.LocationId == id).ToList();
            dataGridView1.DataSource = value;
        }
    }
}
