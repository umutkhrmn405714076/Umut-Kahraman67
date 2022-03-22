using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Giriş_maskeleme_uygulaması_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            maskTC.Mask = "00000000000";
            maskTelefon.Mask = "(999)000 00 00";
            maskDoğumTarihi.Mask = "00/00/0000";
            maskKartNumarası.Mask = "0000-0000-0000-0000";
            maskIP.Mask = "###-###-###-###";
        }
    }
}
