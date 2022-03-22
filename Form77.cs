using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Veri_doğrulama_uygulaması_form_tasarımı_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ErrorProvider ep = new ErrorProvider();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNumara_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(txtNumara.Text,out int sonuc))
            ;
            {
                ep.SetError(txtNumara,"");
            }
            else
            {
                e.Cancel = true;
                ep.SetError(txtNumara,"NUMARA GİRİŞ HATALI");
            }
        }
    }
}
