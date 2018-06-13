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
    public partial class FormEx7 : Form
    {
        public FormEx7()
        {
            InitializeComponent();
        }

        private void FormEx7_Load(object sender, EventArgs e)
        {
            double Arlindo = 1.50, Manoel = 1.10;
            int a = 0;

            while (Arlindo > Manoel)
            {
                Arlindo += 0.02;
                Manoel += 0.03;
                a++;
            }
            txbResult.Text = a.ToString();
        }
        }
    }

