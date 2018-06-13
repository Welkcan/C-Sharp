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
    public partial class FormEx5 : Form
    {
        public FormEx5()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            
            
            //comando pra bloquear letras :3
            if (System.Text.RegularExpressions.Regex.IsMatch(txbNum.Text, "[^0-9]"))
            {
                lblResult.Text = "ESSE PROGRAMA SÓ ACEITA NÚMEROS.";
            }
            
            else
            {
                double num = System.Convert.ToDouble(txbNum.Text);

                if (num <= 50)
                {
                    for (int i = 1; i < num; i++)
                    {
                        lblResult.Text += i + ", ";
                    }

                    lblResult.Text += num + ".";
                }
                else {
                    lblResult.Text = "Algo de errado não está certo...";                
                }
            }
        }
    }
}

