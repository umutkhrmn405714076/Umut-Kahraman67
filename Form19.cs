using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Editor_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Kopyala()
        {
            yazmaAlani.Copy();
        }

        public void Kes()
        {
            yazmaAlani.Cut();
        }

        public void Yapistir()
        {
            yazmaAlani.Paste();
        }

        public void Tumsec()
        {
            yazmaAlani.SelectAll();
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yazmaAlani.Clear();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PROGRAM KAPATILIYOR");
            Application.Exit();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kopyala();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kes();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yapistir();
        }

        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tumsec();
        }

        private void yazmaAlani_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this, new Point(e.X, e.Y));
            }
        }

        private void kopyalaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Kopyala();
        }

        private void kesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Kes();
        }

        private void yapıştırToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Yapistir();
        }

        private void tümünüSeçToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tumsec();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dosya;
            openFileDialog1.Filter = "Metin Dosyası |*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dosya = openFileDialog1.FileName;

                yazmaAlani.LoadFile(dosya, RichTextBoxStreamType.PlainText);
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dosya;
            saveFileDialog1.Filter = "Metin Dosyası |*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dosya = saveFileDialog1.FileName;
                yazmaAlani.SaveFile(dosya, RichTextBoxStreamType.PlainText);
            }
        }

        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                yazmaAlani.Font = fontDialog1.Font;
            }
        }

        private void yardımKonularıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String dosyaYolu = helpProvider1.HelpNamespace.ToString();
            Help.ShowHelp(this, dosyaYolu);
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yeni hakinda = new yeni();
            hakinda.ShowDialog();
        }
    }
}


