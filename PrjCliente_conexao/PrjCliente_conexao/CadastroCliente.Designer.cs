namespace PrjCliente_conexao
{
    partial class CadastroCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblEndereço = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbEndereço = new System.Windows.Forms.TextBox();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.DataNascimento = new System.Windows.Forms.DateTimePicker();
            this.BDClientes = new System.Windows.Forms.DataGridView();
            this.maskCep = new System.Windows.Forms.MaskedTextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.lblNumeroMatricula = new System.Windows.Forms.Label();
            this.txbPesquisar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BDClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(35, 44);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(67, 13);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matricula::";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(35, 75);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome::";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.Location = new System.Drawing.Point(35, 109);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(81, 13);
            this.lblNascimento.TabIndex = 2;
            this.lblNascimento.Text = "Nascimento::";
            // 
            // lblEndereço
            // 
            this.lblEndereço.AutoSize = true;
            this.lblEndereço.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereço.Location = new System.Drawing.Point(35, 145);
            this.lblEndereço.Name = "lblEndereço";
            this.lblEndereço.Size = new System.Drawing.Size(69, 13);
            this.lblEndereço.TabIndex = 3;
            this.lblEndereço.Text = "Endereço::";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(35, 182);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(58, 13);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.Text = "Número::";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(128, 72);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 5;
            // 
            // txbEndereço
            // 
            this.txbEndereço.Location = new System.Drawing.Point(128, 142);
            this.txbEndereço.Name = "txbEndereço";
            this.txbEndereço.Size = new System.Drawing.Size(100, 20);
            this.txbEndereço.TabIndex = 7;
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(128, 179);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(100, 20);
            this.txbNumero.TabIndex = 8;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(238, 182);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(39, 13);
            this.lblCEP.TabIndex = 10;
            this.lblCEP.Text = "CEP::";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Location = new System.Drawing.Point(418, 44);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 11;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(418, 74);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(418, 103);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(418, 132);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeiro.Location = new System.Drawing.Point(38, 246);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(75, 23);
            this.btnPrimeiro.TabIndex = 15;
            this.btnPrimeiro.Text = "Primeiro";
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(117, 246);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 16;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnProximo
            // 
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(198, 246);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 17;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            // 
            // btnUltimo
            // 
            this.btnUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.Location = new System.Drawing.Point(279, 246);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(75, 23);
            this.btnUltimo.TabIndex = 18;
            this.btnUltimo.Text = "Último";
            this.btnUltimo.UseVisualStyleBackColor = true;
            // 
            // DataNascimento
            // 
            this.DataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataNascimento.Location = new System.Drawing.Point(128, 109);
            this.DataNascimento.Name = "DataNascimento";
            this.DataNascimento.Size = new System.Drawing.Size(100, 20);
            this.DataNascimento.TabIndex = 19;
            // 
            // BDClientes
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BDClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BDClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BDClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.BDClientes.Location = new System.Drawing.Point(2, 286);
            this.BDClientes.Name = "BDClientes";
            this.BDClientes.Size = new System.Drawing.Size(645, 150);
            this.BDClientes.TabIndex = 20;
            // 
            // maskCep
            // 
            this.maskCep.Location = new System.Drawing.Point(279, 179);
            this.maskCep.Mask = "00000-000";
            this.maskCep.Name = "maskCep";
            this.maskCep.Size = new System.Drawing.Size(100, 20);
            this.maskCep.TabIndex = 21;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.Location = new System.Drawing.Point(22, 462);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(128, 13);
            this.lblPesquisar.TabIndex = 22;
            this.lblPesquisar.Text = "Pesquisar por Nome::";
            // 
            // lblNumeroMatricula
            // 
            this.lblNumeroMatricula.AutoSize = true;
            this.lblNumeroMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroMatricula.Location = new System.Drawing.Point(128, 43);
            this.lblNumeroMatricula.Name = "lblNumeroMatricula";
            this.lblNumeroMatricula.Size = new System.Drawing.Size(14, 13);
            this.lblNumeroMatricula.TabIndex = 23;
            this.lblNumeroMatricula.Text = "1";
            // 
            // txbPesquisar
            // 
            this.txbPesquisar.Location = new System.Drawing.Point(156, 459);
            this.txbPesquisar.Name = "txbPesquisar";
            this.txbPesquisar.Size = new System.Drawing.Size(251, 20);
            this.txbPesquisar.TabIndex = 24;
            this.txbPesquisar.TextChanged += new System.EventHandler(this.txbPesquisar_TextChanged);
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 623);
            this.Controls.Add(this.txbPesquisar);
            this.Controls.Add(this.lblNumeroMatricula);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.maskCep);
            this.Controls.Add(this.BDClientes);
            this.Controls.Add(this.DataNascimento);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.txbEndereço);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblEndereço);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CadastroCliente";
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.CadastroCliente_Load);
            this.Click += new System.EventHandler(this.CadastroCliente_Click);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CadastroCliente_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.BDClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblEndereço;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbEndereço;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.DateTimePicker DataNascimento;
        private System.Windows.Forms.DataGridView BDClientes;
        private System.Windows.Forms.MaskedTextBox maskCep;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Label lblNumeroMatricula;
        private System.Windows.Forms.TextBox txbPesquisar;
    }
}