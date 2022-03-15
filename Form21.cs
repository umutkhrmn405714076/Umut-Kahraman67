using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TabControl_sekme_sayfası_tasarımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                //............................................................................
                txtBilgi.Text = "";
                txtBilgi.Text += txtAdSoyad.Text + "\r\n";
                txtBilgi.Text += txtTel.Text + "\r\n";
                txtBilgi.Text += txtAdres.Text + "\r\n";
                //............................................................................
                decimal hesap = 0;
                //............................................................................
                if (nÇorba.Value > 0)
                {
                    hesap += nÇorba.Value*12; //ADET FİYATI 12 TL/
                    txtBilgi.Text += string.Format("Çorba {0;C}", nÇorba.Value*12) + "\r\n";
                }
                //............................................................................
                txtBilgi.Text += ".........";
                txtBilgi.Text += string.Format("Toplam {0;C}", hesap);
            }
        }
    }
}
