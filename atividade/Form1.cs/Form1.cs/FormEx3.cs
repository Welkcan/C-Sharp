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
    public partial class FormEx3 : Form
    {
        public FormEx3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";

            double num1 = System.Convert.ToDouble(txb1.Text);
            double num2 = System.Convert.ToDouble(txb2.Text);
            double num3 = System.Convert.ToDouble(txb3.Text);

            if (num1 == num2 && num2 == num3)
            {
                lblResult.Text = "Triangulo Equilátero – possui os três lados com medidas iguais";
            }
            if (num1 == num2 && num1 != num3 || num1 != num2 && num1 == num3 || num1 != num3 && num2 == num3)
            {
                lblResult.Text = "Triangulo Isósceles – possui dois lados com medidas iguais";
            }
            if (num1 != num2 && num2 != num3 && num1 != num3)
            {
                lblResult.Text = "Triangulo Escaleno – possui os três lados com medidas diferentes";
            }
        }
        }
    }

