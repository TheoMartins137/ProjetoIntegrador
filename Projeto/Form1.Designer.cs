namespace Projeto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnCadastro = new Button();
            btnAtualizar = new Button();
            cbxCategoria = new ComboBox();
            cbxRoupaGnr = new ComboBox();
            cbxRoupaTmn = new ComboBox();
            cbxRoupaTipo = new ComboBox();
            lblProcurar = new Label();
            cbxEletroTipo = new ComboBox();
            cbxEletroVolt = new ComboBox();
            cbxLivroGnr = new ComboBox();
            cbxLivroEstado = new ComboBox();
            cbxBrinqTipo = new ComboBox();
            cbxBrinqIdade = new ComboBox();
            cbxBrinqTmn = new ComboBox();
            lblPesquisa = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(948, 433);
            dataGridView1.TabIndex = 0;
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(12, 26);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(120, 66);
            btnCadastro.TabIndex = 3;
            btnCadastro.Text = "Cadastrar";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(809, 20);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(151, 38);
            btnAtualizar.TabIndex = 4;
            btnAtualizar.Text = "Procurar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // cbxCategoria
            // 
            cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Items.AddRange(new object[] { "Roupas", "Eletrodomesticos", "Livros", "Brinquedos" });
            cbxCategoria.Location = new Point(495, 30);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(151, 28);
            cbxCategoria.TabIndex = 5;
            // 
            // cbxRoupaGnr
            // 
            cbxRoupaGnr.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRoupaGnr.Enabled = false;
            cbxRoupaGnr.FormattingEnabled = true;
            cbxRoupaGnr.Items.AddRange(new object[] { "Masculino", "Feminino", "Infantil" });
            cbxRoupaGnr.Location = new Point(495, 64);
            cbxRoupaGnr.Name = "cbxRoupaGnr";
            cbxRoupaGnr.Size = new Size(151, 28);
            cbxRoupaGnr.TabIndex = 6;
            cbxRoupaGnr.Visible = false;
            // 
            // cbxRoupaTmn
            // 
            cbxRoupaTmn.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRoupaTmn.Enabled = false;
            cbxRoupaTmn.FormattingEnabled = true;
            cbxRoupaTmn.Items.AddRange(new object[] { "PP", "P", "M", "G", "GG" });
            cbxRoupaTmn.Location = new Point(652, 64);
            cbxRoupaTmn.Name = "cbxRoupaTmn";
            cbxRoupaTmn.Size = new Size(151, 28);
            cbxRoupaTmn.TabIndex = 7;
            cbxRoupaTmn.Visible = false;
            // 
            // cbxRoupaTipo
            // 
            cbxRoupaTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRoupaTipo.Enabled = false;
            cbxRoupaTipo.FormattingEnabled = true;
            cbxRoupaTipo.Items.AddRange(new object[] { "Camiseta", "Calça", "Bermuda", "Vestido", "Blusa", "Roupa Íntima" });
            cbxRoupaTipo.Location = new Point(809, 64);
            cbxRoupaTipo.Name = "cbxRoupaTipo";
            cbxRoupaTipo.Size = new Size(151, 28);
            cbxRoupaTipo.TabIndex = 8;
            cbxRoupaTipo.Visible = false;
            // 
            // lblProcurar
            // 
            lblProcurar.AutoSize = true;
            lblProcurar.Location = new Point(182, 33);
            lblProcurar.Name = "lblProcurar";
            lblProcurar.Size = new Size(307, 20);
            lblProcurar.TabIndex = 9;
            lblProcurar.Text = "Selecione o tipo de produto para a pesquisa:";
            // 
            // cbxEletroTipo
            // 
            cbxEletroTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEletroTipo.Enabled = false;
            cbxEletroTipo.FormattingEnabled = true;
            cbxEletroTipo.Items.AddRange(new object[] { "Geladeira", "Fogão", "Máquina de lavar", "Televisão", "Liquidificador", "Batedeira", "Aspirador", "Ventilador" });
            cbxEletroTipo.Location = new Point(495, 64);
            cbxEletroTipo.Name = "cbxEletroTipo";
            cbxEletroTipo.Size = new Size(151, 28);
            cbxEletroTipo.TabIndex = 10;
            cbxEletroTipo.Visible = false;
            // 
            // cbxEletroVolt
            // 
            cbxEletroVolt.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEletroVolt.Enabled = false;
            cbxEletroVolt.FormattingEnabled = true;
            cbxEletroVolt.Items.AddRange(new object[] { "110V", "220V", "Bivolt" });
            cbxEletroVolt.Location = new Point(652, 64);
            cbxEletroVolt.Name = "cbxEletroVolt";
            cbxEletroVolt.Size = new Size(151, 28);
            cbxEletroVolt.TabIndex = 11;
            cbxEletroVolt.Visible = false;
            // 
            // cbxLivroGnr
            // 
            cbxLivroGnr.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxLivroGnr.Enabled = false;
            cbxLivroGnr.FormattingEnabled = true;
            cbxLivroGnr.Items.AddRange(new object[] { "Escolar", "Historia", "Ficção Científica", "Religioso", "Poesia", "Infantil", "Contos" });
            cbxLivroGnr.Location = new Point(495, 64);
            cbxLivroGnr.Name = "cbxLivroGnr";
            cbxLivroGnr.Size = new Size(151, 28);
            cbxLivroGnr.TabIndex = 12;
            cbxLivroGnr.Visible = false;
            // 
            // cbxLivroEstado
            // 
            cbxLivroEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxLivroEstado.Enabled = false;
            cbxLivroEstado.FormattingEnabled = true;
            cbxLivroEstado.Items.AddRange(new object[] { "Novo", "Semi-novo", "Usado", "Bem usado", "Destruído" });
            cbxLivroEstado.Location = new Point(652, 64);
            cbxLivroEstado.Name = "cbxLivroEstado";
            cbxLivroEstado.Size = new Size(151, 28);
            cbxLivroEstado.TabIndex = 13;
            cbxLivroEstado.Visible = false;
            // 
            // cbxBrinqTipo
            // 
            cbxBrinqTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBrinqTipo.Enabled = false;
            cbxBrinqTipo.FormattingEnabled = true;
            cbxBrinqTipo.Items.AddRange(new object[] { "Educativo", "Musical", "Eletrônico", "Criativo", "Esporte", "Tabuleiro", "Cartas", "Construção", "Veículos", "Bonecos" });
            cbxBrinqTipo.Location = new Point(495, 64);
            cbxBrinqTipo.Name = "cbxBrinqTipo";
            cbxBrinqTipo.Size = new Size(151, 28);
            cbxBrinqTipo.TabIndex = 14;
            cbxBrinqTipo.Visible = false;
            // 
            // cbxBrinqIdade
            // 
            cbxBrinqIdade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBrinqIdade.Enabled = false;
            cbxBrinqIdade.FormattingEnabled = true;
            cbxBrinqIdade.Items.AddRange(new object[] { "0 - 12 Meses", "1 - 3 Anos", "4 - 6 Anos", "1 - 12 Anos", "13+ Anos" });
            cbxBrinqIdade.Location = new Point(652, 64);
            cbxBrinqIdade.Name = "cbxBrinqIdade";
            cbxBrinqIdade.Size = new Size(151, 28);
            cbxBrinqIdade.TabIndex = 15;
            cbxBrinqIdade.Visible = false;
            // 
            // cbxBrinqTmn
            // 
            cbxBrinqTmn.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBrinqTmn.Enabled = false;
            cbxBrinqTmn.FormattingEnabled = true;
            cbxBrinqTmn.Items.AddRange(new object[] { "Pequeno (Portátil)", "Médio", "Grande(Uso ao ar livre ou ocupa muito espaço)" });
            cbxBrinqTmn.Location = new Point(809, 64);
            cbxBrinqTmn.Name = "cbxBrinqTmn";
            cbxBrinqTmn.Size = new Size(151, 28);
            cbxBrinqTmn.TabIndex = 16;
            cbxBrinqTmn.Visible = false;
            // 
            // lblPesquisa
            // 
            lblPesquisa.AutoSize = true;
            lblPesquisa.Enabled = false;
            lblPesquisa.Location = new Point(340, 67);
            lblPesquisa.Name = "lblPesquisa";
            lblPesquisa.Size = new Size(149, 20);
            lblPesquisa.TabIndex = 17;
            lblPesquisa.Text = "Oriente sua pesquisa:";
            lblPesquisa.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 553);
            Controls.Add(lblPesquisa);
            Controls.Add(cbxBrinqTmn);
            Controls.Add(cbxBrinqIdade);
            Controls.Add(cbxBrinqTipo);
            Controls.Add(cbxLivroEstado);
            Controls.Add(cbxLivroGnr);
            Controls.Add(cbxEletroVolt);
            Controls.Add(cbxEletroTipo);
            Controls.Add(lblProcurar);
            Controls.Add(cbxRoupaTipo);
            Controls.Add(cbxRoupaTmn);
            Controls.Add(cbxRoupaGnr);
            Controls.Add(cbxCategoria);
            Controls.Add(btnAtualizar);
            Controls.Add(btnCadastro);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnCadastro;
        private Button btnAtualizar;
        private ComboBox cbxCategoria;
        private ComboBox cbxRoupaGnr;
        private ComboBox cbxRoupaTmn;
        private ComboBox cbxRoupaTipo;
        private Label lblProcurar;
        private ComboBox cbxEletroTipo;
        private ComboBox cbxEletroVolt;
        private ComboBox cbxLivroGnr;
        private ComboBox cbxLivroEstado;
        private ComboBox cbxBrinqTipo;
        private ComboBox cbxBrinqIdade;
        private ComboBox cbxBrinqTmn;
        private Label lblPesquisa;
    }
}
