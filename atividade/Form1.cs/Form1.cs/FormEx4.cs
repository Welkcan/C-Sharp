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
    public partial class FormEx4 : Form
    {
        public FormEx4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txb1.Text == "1")
            {
                lblResult.Text = "Janeiro é o Mês ";
            }

            else if (txb1.Text == "2")
            {
                lblResult.Text = "Fevereiro é o Mês ";
            }

            else if (txb1.Text == "3")
            {
                lblResult.Text = "Março é o Mês ";
            }

            else if (txb1.Text == "4")
            {
                lblResult.Text = "Abril é o Mês ";
            }

            else if (txb1.Text == "5")
            {
                lblResult.Text = "Maio é o Mês ";
            }

            else if (txb1.Text == "6 é o Mês ")
            {
                lblResult.Text = "Junho é o Mês ";
            }

            else if (txb1.Text == "7")
            {
                lblResult.Text = "Julho é o Mês ";
            }

            else if (txb1.Text == "8")
            {
                lblResult.Text = "Agosto é o Mês ";
            }

            else if (txb1.Text == "9")
            {
                lblResult.Text = "Setembro é o Mês ";
            }

            else if (txb1.Text == "10")
            {
                lblResult.Text = "Outubro é o Mês ";
            }

            else if (txb1.Text == "11")
            {
                lblResult.Text = "Novembro é o Mês ";
            }

            else if (txb1.Text == "12")
            {
                lblResult.Text = "Dezembro é o Mês ";
            }

            else
            {
                lblResult.Text = "Algo de errado não está certo";
            }
            
            
            }
    }
}
