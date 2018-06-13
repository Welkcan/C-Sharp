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
    public partial class FormEx6 : Form
    {
        public FormEx6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";

            if (System.Text.RegularExpressions.Regex.IsMatch(txbNumber.Text, "[^0-9]"))
            {
                lblResult.Text = "Apenas números de 1 até 12";
            }
            else
            {
                double num = System.Convert.ToDouble(txbNumber.Text);

                lblResult.Text = "Brasil, ";
                for (int i = 1; i < num; i++)
                {
                    lblResult.Text += "Brasil, ";
                }
            }
        }
    }
}
