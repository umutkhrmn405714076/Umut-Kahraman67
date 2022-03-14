using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Form_A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter Tuşu Çalışıyor");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esc Tuşu Çalışıyor");
        }

        private void btnControlBox_Click(object sender, EventArgs e)
        {
            if (this.ControlBox == true)
                this.ControlBox = false;
            else
                this.ControlBox = true;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FormB formB = new FormB();
            formB.Show();
        }

        private void btnCenterToScreen_Click(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            FormB formB = new FormB();
            formB.ShowDialog();
        }
    }
}
