using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToolTip_uygulaması_form_tasarımı_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(txtAd,"ADINIZI GİRİNİZ.");
            tt.SetToolTip(txtSoyad,"SOYADINIZI GİRİNİZ.");
            tt.SetToolTip(txtDoğumTarihi,"DOĞUM TARİHİNİZİ GG/AA/YYYY ŞEKLİNDE GİRİNİZ.");
            tt.SetToolTip(txtAdres,"ADRESİNİZİ GİRİNİZ.");
            tt.SetToolTip(btnKaydet,"KAYDETMEK İÇİN TIKALYINIZ.");
        }
    }
}
