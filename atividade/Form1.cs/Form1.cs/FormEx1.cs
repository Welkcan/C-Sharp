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
    public partial class FormEx1 : Form
    {
        public FormEx1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(txb1.Text);
            int valor2 = Convert.ToInt32(txb2.Text);
            int soma = valor1 + valor2;

            if (soma >= 20)
            {
                soma = soma + 8;
                lblResultado.Text = "Resultado (+8): " + soma;
            }

            else 
            {
                soma = soma - 5;
                lblResultado.Text = "Resultado (-5): " + soma;
                
            }

        }
    }
}

