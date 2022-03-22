using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Basit_veri_bağlama_uygulaması_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBağla_Click(object sender, EventArgs e)
        {
            Ogrenciler ogrenci = new Ogrenciler();
            ogrenci.Numara = 1111;
            ogrenci.AdSoyad = "UMUT";
            ogrenci.Alan = "BİLİŞİM TEKNOLOJİLERİ";
            txtNumara.DataBindings.Add("Text",ogrenci, "Numara");
            txtAdSoyad.DataBindings.Add("Text", ogrenci, "Ad Soyad");
            txtAlan.DataBindings.Add("Text", ogrenci, "Alan");
        }
    }
}
