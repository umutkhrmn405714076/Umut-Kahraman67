using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kompleks_veri_bağlama_uygulaması_form_tasarımı_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Sehirler>listSehirler = new List<Sehirler>(); 

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Sehirler sehir = new Sehirler();
            sehir.Plaka = txtPlaka.Text;
            sehir.SehirAdi =txtŞehirAdi.Text
        }
    }
}
