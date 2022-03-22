using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kompleks_veri_bağlama_uygulaması_form_tasarımı_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVeriBağla_Click(object sender, EventArgs e)
        {
            string[] diller = {"C#", "Java", "Python", "Delphi"};
            listeVeriler.DataSource = diller;
        }
    }
}
