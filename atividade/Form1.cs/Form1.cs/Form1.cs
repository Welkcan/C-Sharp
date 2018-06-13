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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void ex1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEx1 Ex1 = new FormEx1();
            //Ex1.MdiParent = this;
            Ex1.Show();

        }

        private void ex2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEx2 Ex2 = new FormEx2();
            //Ex2.MdiParent = this;
            Ex2.Show();
        }

        private void ex3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEx3 Ex3 = new FormEx3();
            //Ex3.MdiParent = this;
            Ex3.Show();
        }

        private void ex4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEx4 Ex4 = new FormEx4();
            //Ex4.MdiParent = this;
            Ex4.Show();
        }

        private void ex5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEx5 Ex5 = new FormEx5();
            //Ex5.MdiParent = this;
            Ex5.Show();
        }

        private void ex6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEx6 Ex6 = new FormEx6();
            //Ex6.MdiParent = this;
            Ex6.Show();
        }

        private void ex7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEx7 Ex7 = new FormEx7();
            //Ex7.MdiParent = this;
            Ex7.Show();
        }
    }
}
