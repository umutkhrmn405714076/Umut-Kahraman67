using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LocalDataHelper;

namespace Proje_Hesaplama
{
    public partial class Form1 : Form
    {
        private ProjeÖdevTakibi prtkp;


        public Form1()
        {
            InitializeComponent();

            lbOgrenciTakibi.Items.Load<ProjeÖdevTakibi>("Bilgiler.dat");
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            prtkp = null;
            txtNo.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            cbDers.Text = "";
            txtKonu.Text = "";
            txtNot.Text = "";
        }

        private void btnKaydet(object sender, EventArgs e)
        {
            bool yeni = false;
            if (prtkp == null)
            {
                yeni = true;
                prtkp = new ProjeÖdevTakibi();
            }

            prtkp.No = txtNo.Text;
            prtkp.Ad = txtAd.Text;
            prtkp.Soyad = txtSoyad.Text;
            prtkp.Ders = cbDers.SelectedIndex;
            prtkp.Konu = txtKonu.Text;
            prtkp.Not = Convert.ToInt32(txtNot.Text);

            if (yeni)
                lbOgrenciTakibi.Items.Add(prtkp);

            else
            {
                int index = lbOgrenciTakibi.Items.IndexOf(prtkp);
                lbOgrenciTakibi.Items[index] = lbOgrenciTakibi.Items[index];

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show(prtkp.ToString() + "- Silinsin mi?", "Uyarı", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                int index = lbOgrenciTakibi.Items.IndexOf(prtkp);
                lbOgrenciTakibi.Items.RemoveAt(index);
            }
        }

        private void lbOgrenciTakibi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbOgrenciTakibi.SelectedIndex;
            if (index >= 0)
            {
                prtkp = (ProjeÖdevTakibi) lbOgrenciTakibi.Items[index];

                txtNo.Text = prtkp.No.ToString();
                txtAd.Text = prtkp.Ad;
                txtSoyad.Text = prtkp.Soyad;
                cbDers.SelectedIndex = prtkp.Ders;
                txtKonu.Text = prtkp.Konu;
                txtNot.Text = prtkp.Not.ToString();
            }
        }

        private void btnDosyayaKaydet_Click(object sender, EventArgs e)
        {
            lbOgrenciTakibi.Items.Save("Bilgiler.dat");
        }
    }
}    
            