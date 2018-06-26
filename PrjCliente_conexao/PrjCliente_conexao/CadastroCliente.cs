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
    public partial class CadastroCliente : Form
    {
        //Conectar através da classe Conexao
        OleDbConnection conn = Conexao.obterConexao();
        //Declare o DataReader  -- tabela virtual somente leitura
        OleDbDataReader dr_clientes;
        //Declare o BindingSource -- tabela virtual editável
        BindingSource bs_clientes = new BindingSource();
        // cria a variavel que receberá a query (comando sql)
        String _query;

        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void carregar_grid()
        {
            //Determine a query desejada
            _query = "Select * from clientes";
            //declare o objeto DataCommand passando a query e o objeto de conexão
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            //execute o método ExecuteReader que retornará um DataReader preenchido com a query
            dr_clientes = _dataCommand.ExecuteReader();
            //Teste para verificar se retornaram linhas
            if (dr_clientes.HasRows == true)
            {
                bs_clientes.DataSource = dr_clientes;
                BDClientes.DataSource = bs_clientes;
                igualar_text();
            }
            else
            {
                MessageBox.Show("Não temos clientes cadastrados !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void igualar_text()
        {
            lblNumeroMatricula.DataBindings.Add("Text", bs_clientes, "Matricula");
            lblMatricula.DataBindings.Clear();
            txbNome.DataBindings.Add("Text", bs_clientes, "Nome");
            txbNome.DataBindings.Clear();
            txbEndereço.DataBindings.Add("Text", bs_clientes, "End");
            txbEndereço.DataBindings.Clear();
            txbNumero.DataBindings.Add("Text", bs_clientes, "Num");
            txbNumero.DataBindings.Clear();
            maskCep.DataBindings.Add("Text", bs_clientes, "Cep");
            maskCep.DataBindings.Clear();
            DataNascimento.DataBindings.Add("Text", bs_clientes, "Nasc");
            DataNascimento.DataBindings.Clear();
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            // carregar o datagridview com dados
            carregar_grid();
        }

        private void CadastroCliente_Click(object sender, EventArgs e)
        {
            igualar_text();
        }

        private void CadastroCliente_KeyUp(object sender, KeyEventArgs e)
        {
            igualar_text();
        }

        private void txbPesquisar_TextChanged(object sender, EventArgs e)
        {
            _query = "Select * from Clientes where nome like '" + txbPesquisar.Text + "%'";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_clientes = _dataCommand.ExecuteReader();

            if (dr_clientes.HasRows == true)
            {
                bs_clientes.DataSource = dr_clientes;
            }
            else
            {
                MessageBox.Show("Não temos cliente cadastrado com este nome !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPesquisar.Text = "";
            }

        }

    }
}
