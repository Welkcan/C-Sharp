using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace PrjCliente_conexao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente Cadastro = new CadastroCliente();
            Cadastro.MdiParent = this;
            Cadastro.Show();
        }
    }
}
