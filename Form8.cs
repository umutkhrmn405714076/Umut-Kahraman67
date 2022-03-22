using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Basit_veri_bağlama_uygulaması_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Binding bagla = new Binding("Text", txtKaynak, "Text");
            txtHedef.DataBindings.Add(bagla);
        }
    }
}
