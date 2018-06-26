using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;


namespace PrjCliente_conexao
{
    class Conexao
    {
        //Declare o objeto de conexão passando como parâmetro a string de conexão
        private static string coonString = @"Provider=Microsoft.ACE.OLEDB.12.0;
                Data Source=|DataDirectory|\bdteste.accdb;Persist Security Info=False;";


        // variável que representa a conexão com o banco
        private static OleDbConnection conn = null;

        public static OleDbConnection obterConexao()
        {
            // vamos criar a conexão
            conn = new OleDbConnection(coonString);

            // a conexão foi feita com sucesso?
            try
            {
                // abre a conexão e a devolve ao chamador do método
                conn.Open();
            }
            catch (Exception e)
            {
                conn = null;
                MessageBox.Show("Conexão não estabelecida!!" +e);
                // ops! o que aconteceu?
                // uma boa idéia aqui é gravar a exceção em um arquivo de log
            }

            return conn;
        }

        //***********************************
        // método que permite fechar a conexão
        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }



    }
}
