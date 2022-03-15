using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Panel_kontrollerinin_form_üzerinde_yerleşimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGit_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtAdres.Text);
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void webBrowser1_Navigated_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(webBrowser1.Url);
        }
    }
}
