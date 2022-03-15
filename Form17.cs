using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GroupBox_uygulaması_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal tabanFiyat = 500;
            
            //İŞLEMCİ FİYAT HESAPLAMASI
            
            decimal cpuFiyat = 0;
            
            if (rbCpul7.Checked)
                cpuFiyat = 10499;
            
            else if (rbCpul5.Checked)
                cpuFiyat = 7797;
            
            else if (rbCpul3.Checked)
                cpuFiyat = 3757;
            
            else if (rbCpuR5.Checked)
                cpuFiyat = 4549;
            
            else if (rbCpuR3.Checked)
                cpuFiyat = 4550;
            tabanFiyat += cpuFiyat;
            
            //RAM BELLEK FİYAT HESAPLAMASI

            decimal ramFiyat = 0;

            if (rbRam16.Checked)
                cpuFiyat = 1629;

            else if (rbRam8.Checked)
                cpuFiyat = 595;
            
            else if (rbRam4.Checked)
                cpuFiyat = 1973;

            tabanFiyat += ramFiyat;

            MessageBox.Show(string.Format("Taban Fiyat {0;C}", tabanFiyat));
            
            decimal hddFiyat = 0;
            
            if (rbHdd1000.Checked)
                hddFiyat = 800;
            
            if (rbHdd500.Checked)
                hddFiyat = 570;

            if (rbHdd320.Checked)
                hddFiyat = 340;

            decimal cbFiyat = 0;

            if (cbDWD.Checked)
                cbFiyat = 900;
            if (cbWepCam.Checked)
                cbFiyat = 700;
            if (cbWifi.Checked)
                cbFiyat = 550;
        }
    }
}
