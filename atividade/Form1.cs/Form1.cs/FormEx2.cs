using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Form1.cs
{
    public partial class FormEx2 : Form
    {
        public FormEx2()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";

            if (System.Convert.ToDouble(txbNum.Text) % 2 == 0 || System.Convert.ToDouble(txbNum.Text) % 5 == 0 || System.Convert.ToDouble(txbNum.Text) % 10 == 0)
            {
                lblResult.Text = "É divisível por ";
            }
            else
            {
                lblResult.Text = "Não é divisível por 2, 5 e 10";
            }

            if (System.Convert.ToDouble(txbNum.Text) % 2 == 0)
            {
                lblResult.Text += "2 ";
            }
            if (System.Convert.ToDouble(txbNum.Text) % 5 == 0)
            {
                lblResult.Text += "5 ";
            }
            if (System.Convert.ToDouble(txbNum.Text) % 10 == 0)
            {
                lblResult.Text += "10 ";
            }
            
        }
    }
}
