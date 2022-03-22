using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kompleks_veri_bağlama_uygulaması_form_tasarımı_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList kaynakVeri =new ArrayList();

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            Kitaplar kitap = new Kitaplar();
            kitap.KitapAdi = txtKitapAdi.Text;
            kitap.KitapYazari = txtKitapYazari.Text;
            kitap.KitapTuru = txtKitapTuru.Text;
            kaynakVeri.Add(kitap);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            ListeVeri.DataSource = null;
            ListeVeri.DataSource = kaynakVeri;
            ListeVeri.DataSource = "KitapAdi";
        }
    }
}
