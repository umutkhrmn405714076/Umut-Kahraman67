using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotDefteri
{
    public partial class Form1 : Form
    {
        DosyaYardimcisi dosyaYardimcisi = new DosyaYardimcisi();
        bool degisti = false;

        EditorYardimcisi editorYardimcisi = new EditorYardimcisi();

        public Form1()
        {
            InitializeComponent();

            dosyaYardimcisi.EditorAyarla(txtEditor);
            dosyaYardimcisi.FormAyarla(this);
            editorYardimcisi.EditorAyarla(txtEditor);
        }


        private void miYeni_Click(object sender, EventArgs e)
        {
            dosyaYardimcisi.Yeni();
            degisti = false;
        }

        private void miAc_Click(object sender, EventArgs e)
        {
            DialogResult cevap = openFileDialog1.ShowDialog();

            if (cevap == DialogResult.OK)
            {
                dosyaYardimcisi.Ac(openFileDialog1.FileName);
                degisti = false;
            }
        }

        private void miKaydet_Click(object sender, EventArgs e)
        {
            if (dosyaYardimcisi.YeniDosyaMi)
            {
                DialogResult cevap = saveFileDialog1.ShowDialog();

                if (cevap == DialogResult.OK)
                {
                    dosyaYardimcisi.Kaydet(saveFileDialog1.FileName);
                }
            }
            else
                dosyaYardimcisi.Kaydet();
        }

        private void miFarkliKaydet_Click(object sender, EventArgs e)
        {
            DialogResult cevap = saveFileDialog1.ShowDialog();

            if (cevap == DialogResult.OK)
            {
                dosyaYardimcisi.Kaydet(saveFileDialog1.FileName);
            }

        }

        private void miKapat_Click(object sender, EventArgs e)
        {
            if (degisti)
            {
                DialogResult cevap = MessageBox.Show("Çıkış yapmadan önce değişiklikler kayıt edilsin mi?", 
                    "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)
                    miKaydet_Click(null, null);
                else if (cevap == DialogResult.Cancel)
                    return;
            }

            Close();
        }

        private void txtEditor_TextChanged(object sender, EventArgs e)
        {
            degisti = true;
        }

        private void miKes_Click(object sender, EventArgs e)
        {
            txtEditor.Cut();
        }

        private void miKopyala_Click(object sender, EventArgs e)
        {
           
            txtEditor.Copy();
        }

        private void miYapistir_Click(object sender, EventArgs e)
        {
            txtEditor.Paste();
        }

        private void miTumunuSec_Click(object sender, EventArgs e)
        {
            txtEditor.SelectAll();
        }

        private void miBulVeDegistir_Click(object sender, EventArgs e)
        {
            pnlBul.Visible = true;
        }

        private void btnBulKapat_Click(object sender, EventArgs e)
        {
            pnlBul.Visible = false;
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            editorYardimcisi.Bul(txtBul.Text);
        }
    }
}
