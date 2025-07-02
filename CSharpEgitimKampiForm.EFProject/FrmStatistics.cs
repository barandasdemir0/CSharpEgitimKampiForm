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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities entities = new EgitimKampiEfTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            #region toplam lokasyon sayısı
            lblLocation.Text = entities.Locations.Count().ToString();

            #endregion


            #region  toplam kapasite sayısı
            lblCapasity.Text = entities.Locations.Sum(x => x.Capacity).ToString();
            #endregion

            #region rehber sayısı
            lblGuide.Text = entities.Guides.Count().ToString();
            #endregion

            #region ortalama kapasite
            lblAverage.Text = entities.Locations.Average(x => x.Capacity).ToString();
            #endregion


            #region ortalama tur fiyatı
            lblaverageTour.Text = Math.Round(entities.Locations.Average(x => x.Price).Value, 2).ToString();
            #endregion

            #region eklenen son ülke
            int locationId = entities.Locations.Max(x => x.LocationId);
            lbl_lastCountry.Text = entities.Locations.Where(x => x.LocationId == locationId).Select(y => y.Country).FirstOrDefault();

            #endregion

            #region kapodakya tur kapasitesi
            lblKapodakya.Text = entities.Locations.Where(x => x.City == "Kapodakya").Select(y => y.Capacity).FirstOrDefault().ToString();
            #endregion

            #region türkiye turları ortalama kapasite
            lbl_turkiye_tour.Text = entities.Locations.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();
            #endregion

            #region roma gezisi rehber ismi
            var rehberıd =  entities.Locations.Where(x => x.City == "Roma").Select(y => y.GuideId).FirstOrDefault();
            lbl_roma.Text = entities.Guides.Where(x => x.GuideId == rehberıd).Select(y => y.GuideName+" "+y.GuideSurname).FirstOrDefault().ToString();
            #endregion

            #region en yüksek kapasiteli tur
            var maxTour = entities.Locations.Max(x => x.Capacity);
            lbl_max_tour.Text = entities.Locations.Where(x => x.Capacity == maxTour).Select(y => y.Capacity).FirstOrDefault().ToString();
            #endregion

            #region en pahalı tur
            var maximumMoney = entities.Locations.Max(x => x.Price);
            lbl_Expensive_tour.Text = entities.Locations.Where(x => x.Price == maximumMoney).Select(y => y.Price).FirstOrDefault().ToString();
            #endregion

            #region ali yıldız tur sayısı
            var ali_yildiz = entities.Guides.Where(x => x.GuideName == "Ali" && x.GuideSurname == "Yıldız").Select(y=>y.GuideId).FirstOrDefault();
            lbl_ali_yildiz.Text = entities.Locations.Where(x => x.GuideId == ali_yildiz).Count().ToString();
            #endregion


        }
    }
}
