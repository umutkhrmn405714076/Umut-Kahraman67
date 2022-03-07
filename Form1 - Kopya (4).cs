using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Uygulama_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList kolA= new ArrayList();//Arraylist Koleksiyonu
        List<int> kolL = new List<int>();//List Koleksiyonu
        Stopwatch km = new Stopwatch();//Geçen Süreyi Hesaplama İçin Nesne
        int elemanSayisi = 100000;//Test İçin Eleman Sayısı

        private void btnAEkle_Click(object sender, EventArgs e)
        {
            km.Start();
            for (int i = 0; i < elemanSayisi; i++)
            {
                kolA.Add(i);
            }
            km.Stop();
            lblAEkle.Text = "=" +
            km.Elapsed.TotalMilliseconds;
            km.Reset();
        }

        private void btnEEkle_Click(object sender, EventArgs e)
        {
            km.Start();
            for (int i = 0; i < elemanSayisi; i++)
            {
                kolL.Add(i);
            }
            km.Stop();
            lblLEkle.Text = "=" +
            km.Elapsed.TotalMilliseconds;
            km.Reset();
        }

        private void btnATopla_Click(object sender, EventArgs e)
        {
            km.Start();
            int toplam = 0;
            for (int i = 0; i < kolA.Count;i++)
            {
                toplam += (int) kolA[i];
            }
            km.Stop();
            lblATopla.Text = "=" +
            km.Elapsed.TotalMilliseconds;
            km.Reset();
        }

        private void btnLTopla_Click(object sender, EventArgs e)
        {
            km.Start();
            int toplam = 0;
            for (int i = 0; i < kolL.Count; i++)
            {
                toplam += kolL[i];
            }
            km.Stop();
            lblLTopla.Text = "=" +
            km.Elapsed.TotalMilliseconds;
            km.Reset();
        }

        private void btnAYaz_Click(object sender, EventArgs e)
        {
            km.Start();
            for (int i = 0; i < elemanSayisi; i++)
            {
                ListeA.Items.Add(kolA[i]);
            }
            km.Stop();
            lblAYaz.Text = "=" +
            km.Elapsed.TotalMilliseconds;
            km.Reset();
        }

        private void btnLYaz_Click(object sender, EventArgs e)
        {
            km.Start();
            for (int i = 0; i < kolL.Count; i++)
            {
                ListeL.Items.Add(kolL[i]);
            }
            km.Stop();
            lblLYaz.Text = "=" +
            km.Elapsed.TotalMilliseconds;
            km.Stop();
        }

        private void btnABul_Click(object sender, EventArgs e)
        {
            km.Start();
            if (kolA.Contains(9999))
            {
                km.Stop();
            }
            lblABul.Text = "= " +
            km.Elapsed.TotalMilliseconds;
            km.Reset();
        }

        private void btnLBul_Click(object sender, EventArgs e)
        {
            km.Start();
            if (kolL.Contains(9999))
            {
                km.Stop();
            }
            lblLBul.Text ="=" +
            km.Elapsed.TotalMilliseconds;
            km.Reset();
        }
    }
}
