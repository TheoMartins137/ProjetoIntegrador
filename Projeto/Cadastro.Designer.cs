namespace Projeto
{
    partial class Cadastro
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
            cbxCategoria = new ComboBox();
            btnCadastro = new Button();
            brn_confirmar = new Button();
            txtRoupaNome = new TextBox();
            txtRoupaId = new TextBox();
            cbxRoupaGnr = new ComboBox();
            lblRoupaGnr = new Label();
            lblRoupaTmn = new Label();
            cbxRoupaTmn = new ComboBox();
            lblRoupaTipo = new Label();
            cbxRoupaTipo = new ComboBox();
            txtRoupaDesc = new TextBox();
            lblRoupaDesc = new Label();
            txtEletroNome = new TextBox();
            lblEletroTipo = new Label();
            rdbEletroTipo = new ComboBox();
            cbxEletroVolt = new ComboBox();
            lblEletroVolt = new Label();
            txtLivroNome = new TextBox();
            lblLivroGnr = new Label();
            cbxLivroGenero = new ComboBox();
            cbxLivroEstado = new ComboBox();
            lblLivroEstado = new Label();
            lblRoupaId = new Label();
            cbxBrinqTipo = new ComboBox();
            lblBrinqTipo = new Label();
            cbxBrinqIdade = new ComboBox();
            lblBrinqIdade = new Label();
            cbxBrinqTmn = new ComboBox();
            lblBrinqTmn = new Label();
            txtBrinqNome = new TextBox();
            SuspendLayout();
            // 
            // cbxCategoria
            // 
            cbxCategoria.AllowDrop = true;
            cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Items.AddRange(new object[] { "Roupas", "Eletrodomesticos", "Livros", "Brinquedos" });
            cbxCategoria.Location = new Point(12, 27);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(175, 28);
            cbxCategoria.TabIndex = 0;
            // 
            // btnCadastro
            // 
            btnCadastro.Enabled = false;
            btnCadastro.Location = new Point(12, 501);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(355, 29);
            btnCadastro.TabIndex = 1;
            btnCadastro.Text = "Cadastrar";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Visible = false;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // brn_confirmar
            // 
            brn_confirmar.Location = new Point(193, 26);
            brn_confirmar.Name = "brn_confirmar";
            brn_confirmar.Size = new Size(174, 29);
            brn_confirmar.TabIndex = 2;
            brn_confirmar.Text = "Confirmar";
            brn_confirmar.UseVisualStyleBackColor = true;
            brn_confirmar.Click += brn_confirmar_Click;
            // 
            // txtRoupaNome
            // 
            txtRoupaNome.Enabled = false;
            txtRoupaNome.Location = new Point(12, 124);
            txtRoupaNome.Name = "txtRoupaNome";
            txtRoupaNome.PlaceholderText = "Nome";
            txtRoupaNome.Size = new Size(355, 27);
            txtRoupaNome.TabIndex = 3;
            txtRoupaNome.Visible = false;
            // 
            // txtRoupaId
            // 
            txtRoupaId.Enabled = false;
            txtRoupaId.Location = new Point(193, 74);
            txtRoupaId.Name = "txtRoupaId";
            txtRoupaId.Size = new Size(72, 27);
            txtRoupaId.TabIndex = 4;
            txtRoupaId.Visible = false;
            // 
            // cbxRoupaGnr
            // 
            cbxRoupaGnr.BackColor = SystemColors.Window;
            cbxRoupaGnr.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRoupaGnr.Enabled = false;
            cbxRoupaGnr.FormattingEnabled = true;
            cbxRoupaGnr.Items.AddRange(new object[] { "Masculino", "Feminino", "Infantil" });
            cbxRoupaGnr.Location = new Point(141, 171);
            cbxRoupaGnr.Name = "cbxRoupaGnr";
            cbxRoupaGnr.Size = new Size(128, 28);
            cbxRoupaGnr.TabIndex = 6;
            cbxRoupaGnr.Visible = false;
            // 
            // lblRoupaGnr
            // 
            lblRoupaGnr.AutoSize = true;
            lblRoupaGnr.Enabled = false;
            lblRoupaGnr.Location = new Point(63, 174);
            lblRoupaGnr.Name = "lblRoupaGnr";
            lblRoupaGnr.Size = new Size(60, 20);
            lblRoupaGnr.TabIndex = 7;
            lblRoupaGnr.Text = "Gênero:";
            lblRoupaGnr.Visible = false;
            // 
            // lblRoupaTmn
            // 
            lblRoupaTmn.AutoSize = true;
            lblRoupaTmn.Enabled = false;
            lblRoupaTmn.Location = new Point(63, 219);
            lblRoupaTmn.Name = "lblRoupaTmn";
            lblRoupaTmn.Size = new Size(72, 20);
            lblRoupaTmn.TabIndex = 9;
            lblRoupaTmn.Text = "Tamanho:";
            lblRoupaTmn.Visible = false;
            // 
            // cbxRoupaTmn
            // 
            cbxRoupaTmn.BackColor = SystemColors.Window;
            cbxRoupaTmn.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRoupaTmn.Enabled = false;
            cbxRoupaTmn.FormattingEnabled = true;
            cbxRoupaTmn.Items.AddRange(new object[] { "PP", "P", "M", "G", "GG" });
            cbxRoupaTmn.Location = new Point(141, 216);
            cbxRoupaTmn.Name = "cbxRoupaTmn";
            cbxRoupaTmn.Size = new Size(128, 28);
            cbxRoupaTmn.TabIndex = 8;
            cbxRoupaTmn.Visible = false;
            // 
            // lblRoupaTipo
            // 
            lblRoupaTipo.AutoSize = true;
            lblRoupaTipo.Enabled = false;
            lblRoupaTipo.Location = new Point(63, 266);
            lblRoupaTipo.Name = "lblRoupaTipo";
            lblRoupaTipo.Size = new Size(42, 20);
            lblRoupaTipo.TabIndex = 10;
            lblRoupaTipo.Text = "Tipo:";
            lblRoupaTipo.Visible = false;
            // 
            // cbxRoupaTipo
            // 
            cbxRoupaTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRoupaTipo.Enabled = false;
            cbxRoupaTipo.FormattingEnabled = true;
            cbxRoupaTipo.Items.AddRange(new object[] { "Camiseta", "Calça", "Bermuda", "Vestido", "Blusa", "Roupa Íntima" });
            cbxRoupaTipo.Location = new Point(141, 263);
            cbxRoupaTipo.Name = "cbxRoupaTipo";
            cbxRoupaTipo.Size = new Size(128, 28);
            cbxRoupaTipo.TabIndex = 11;
            cbxRoupaTipo.Visible = false;
            // 
            // txtRoupaDesc
            // 
            txtRoupaDesc.Enabled = false;
            txtRoupaDesc.Location = new Point(12, 352);
            txtRoupaDesc.Multiline = true;
            txtRoupaDesc.Name = "txtRoupaDesc";
            txtRoupaDesc.Size = new Size(355, 143);
            txtRoupaDesc.TabIndex = 12;
            txtRoupaDesc.Visible = false;
            // 
            // lblRoupaDesc
            // 
            lblRoupaDesc.AutoSize = true;
            lblRoupaDesc.Enabled = false;
            lblRoupaDesc.Location = new Point(141, 329);
            lblRoupaDesc.Name = "lblRoupaDesc";
            lblRoupaDesc.Size = new Size(77, 20);
            lblRoupaDesc.TabIndex = 13;
            lblRoupaDesc.Text = "Descrição:";
            lblRoupaDesc.Visible = false;
            // 
            // txtEletroNome
            // 
            txtEletroNome.Enabled = false;
            txtEletroNome.Location = new Point(12, 124);
            txtEletroNome.Name = "txtEletroNome";
            txtEletroNome.PlaceholderText = "Nome";
            txtEletroNome.Size = new Size(355, 27);
            txtEletroNome.TabIndex = 16;
            txtEletroNome.Visible = false;
            // 
            // lblEletroTipo
            // 
            lblEletroTipo.AutoSize = true;
            lblEletroTipo.Enabled = false;
            lblEletroTipo.Location = new Point(63, 194);
            lblEletroTipo.Name = "lblEletroTipo";
            lblEletroTipo.Size = new Size(42, 20);
            lblEletroTipo.TabIndex = 18;
            lblEletroTipo.Text = "Tipo:";
            lblEletroTipo.Visible = false;
            // 
            // rdbEletroTipo
            // 
            rdbEletroTipo.BackColor = SystemColors.Window;
            rdbEletroTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            rdbEletroTipo.Enabled = false;
            rdbEletroTipo.FormattingEnabled = true;
            rdbEletroTipo.Items.AddRange(new object[] { "Geladeira", "Fogão", "Máquina de lavar", "Televisão", "Liquidificador", "Batedeira", "Aspirador", "Ventilador" });
            rdbEletroTipo.Location = new Point(141, 191);
            rdbEletroTipo.Name = "rdbEletroTipo";
            rdbEletroTipo.Size = new Size(128, 28);
            rdbEletroTipo.TabIndex = 17;
            rdbEletroTipo.Visible = false;
            // 
            // cbxEletroVolt
            // 
            cbxEletroVolt.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEletroVolt.Enabled = false;
            cbxEletroVolt.FormattingEnabled = true;
            cbxEletroVolt.Items.AddRange(new object[] { "110V", "220V", "Bivolt" });
            cbxEletroVolt.Location = new Point(141, 236);
            cbxEletroVolt.Name = "cbxEletroVolt";
            cbxEletroVolt.Size = new Size(128, 28);
            cbxEletroVolt.TabIndex = 20;
            cbxEletroVolt.Visible = false;
            // 
            // lblEletroVolt
            // 
            lblEletroVolt.AutoSize = true;
            lblEletroVolt.Enabled = false;
            lblEletroVolt.Location = new Point(59, 239);
            lblEletroVolt.Name = "lblEletroVolt";
            lblEletroVolt.Size = new Size(76, 20);
            lblEletroVolt.TabIndex = 19;
            lblEletroVolt.Text = "Voltagem:";
            lblEletroVolt.Visible = false;
            // 
            // txtLivroNome
            // 
            txtLivroNome.Enabled = false;
            txtLivroNome.Location = new Point(12, 124);
            txtLivroNome.Name = "txtLivroNome";
            txtLivroNome.PlaceholderText = "Nome";
            txtLivroNome.Size = new Size(355, 27);
            txtLivroNome.TabIndex = 27;
            txtLivroNome.Visible = false;
            // 
            // lblLivroGnr
            // 
            lblLivroGnr.AutoSize = true;
            lblLivroGnr.Enabled = false;
            lblLivroGnr.Location = new Point(63, 194);
            lblLivroGnr.Name = "lblLivroGnr";
            lblLivroGnr.Size = new Size(60, 20);
            lblLivroGnr.TabIndex = 29;
            lblLivroGnr.Text = "Gênero:";
            lblLivroGnr.Visible = false;
            // 
            // cbxLivroGenero
            // 
            cbxLivroGenero.BackColor = SystemColors.Window;
            cbxLivroGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxLivroGenero.Enabled = false;
            cbxLivroGenero.FormattingEnabled = true;
            cbxLivroGenero.Items.AddRange(new object[] { "Escolar", "Historia", "Ficção Científica", "Religioso", "Poesia", "Infantil", "Contos" });
            cbxLivroGenero.Location = new Point(141, 191);
            cbxLivroGenero.Name = "cbxLivroGenero";
            cbxLivroGenero.Size = new Size(128, 28);
            cbxLivroGenero.TabIndex = 28;
            cbxLivroGenero.Visible = false;
            // 
            // cbxLivroEstado
            // 
            cbxLivroEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxLivroEstado.Enabled = false;
            cbxLivroEstado.FormattingEnabled = true;
            cbxLivroEstado.Items.AddRange(new object[] { "Novo", "Semi-novo", "Usado", "Bem usado", "Destruído" });
            cbxLivroEstado.Location = new Point(141, 236);
            cbxLivroEstado.Name = "cbxLivroEstado";
            cbxLivroEstado.Size = new Size(128, 28);
            cbxLivroEstado.TabIndex = 31;
            cbxLivroEstado.Visible = false;
            // 
            // lblLivroEstado
            // 
            lblLivroEstado.AutoSize = true;
            lblLivroEstado.Enabled = false;
            lblLivroEstado.Location = new Point(63, 239);
            lblLivroEstado.Name = "lblLivroEstado";
            lblLivroEstado.Size = new Size(57, 20);
            lblLivroEstado.TabIndex = 30;
            lblLivroEstado.Text = "Estado:";
            lblLivroEstado.Visible = false;
            // 
            // lblRoupaId
            // 
            lblRoupaId.AutoSize = true;
            lblRoupaId.Enabled = false;
            lblRoupaId.Location = new Point(90, 77);
            lblRoupaId.Name = "lblRoupaId";
            lblRoupaId.Size = new Size(97, 20);
            lblRoupaId.TabIndex = 5;
            lblRoupaId.Text = "Identificador:";
            lblRoupaId.Visible = false;
            // 
            // cbxBrinqTipo
            // 
            cbxBrinqTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBrinqTipo.Enabled = false;
            cbxBrinqTipo.FormattingEnabled = true;
            cbxBrinqTipo.Items.AddRange(new object[] { "Educativo", "Musical", "Eletrônico", "Criativo", "Esporte", "Tabuleiro", "Cartas", "Construção", "Veículos", "Bonecos" });
            cbxBrinqTipo.Location = new Point(141, 171);
            cbxBrinqTipo.Name = "cbxBrinqTipo";
            cbxBrinqTipo.Size = new Size(128, 28);
            cbxBrinqTipo.TabIndex = 33;
            cbxBrinqTipo.Visible = false;
            // 
            // lblBrinqTipo
            // 
            lblBrinqTipo.AutoSize = true;
            lblBrinqTipo.Enabled = false;
            lblBrinqTipo.Location = new Point(93, 174);
            lblBrinqTipo.Name = "lblBrinqTipo";
            lblBrinqTipo.Size = new Size(42, 20);
            lblBrinqTipo.TabIndex = 32;
            lblBrinqTipo.Text = "Tipo:";
            lblBrinqTipo.Visible = false;
            // 
            // cbxBrinqIdade
            // 
            cbxBrinqIdade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBrinqIdade.Enabled = false;
            cbxBrinqIdade.FormattingEnabled = true;
            cbxBrinqIdade.Items.AddRange(new object[] { "0 - 12 Meses", "1 - 3 Anos", "4 - 6 Anos", "1 - 12 Anos", "13+ Anos" });
            cbxBrinqIdade.Location = new Point(141, 216);
            cbxBrinqIdade.Name = "cbxBrinqIdade";
            cbxBrinqIdade.Size = new Size(128, 28);
            cbxBrinqIdade.TabIndex = 35;
            cbxBrinqIdade.Visible = false;
            // 
            // lblBrinqIdade
            // 
            lblBrinqIdade.AutoSize = true;
            lblBrinqIdade.Enabled = false;
            lblBrinqIdade.Location = new Point(51, 219);
            lblBrinqIdade.Name = "lblBrinqIdade";
            lblBrinqIdade.Size = new Size(87, 20);
            lblBrinqIdade.TabIndex = 34;
            lblBrinqIdade.Text = "Faixa Etária:";
            lblBrinqIdade.Visible = false;
            // 
            // cbxBrinqTmn
            // 
            cbxBrinqTmn.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBrinqTmn.Enabled = false;
            cbxBrinqTmn.FormattingEnabled = true;
            cbxBrinqTmn.Items.AddRange(new object[] { "Pequeno (Portátil)", "Médio", "Grande(Uso ao ar livre ou ocupa muito espaço)" });
            cbxBrinqTmn.Location = new Point(141, 263);
            cbxBrinqTmn.Name = "cbxBrinqTmn";
            cbxBrinqTmn.Size = new Size(128, 28);
            cbxBrinqTmn.TabIndex = 37;
            cbxBrinqTmn.Visible = false;
            // 
            // lblBrinqTmn
            // 
            lblBrinqTmn.AutoSize = true;
            lblBrinqTmn.Enabled = false;
            lblBrinqTmn.Location = new Point(66, 266);
            lblBrinqTmn.Name = "lblBrinqTmn";
            lblBrinqTmn.Size = new Size(72, 20);
            lblBrinqTmn.TabIndex = 36;
            lblBrinqTmn.Text = "Tamanho:";
            lblBrinqTmn.Visible = false;
            // 
            // txtBrinqNome
            // 
            txtBrinqNome.Enabled = false;
            txtBrinqNome.Location = new Point(12, 124);
            txtBrinqNome.Name = "txtBrinqNome";
            txtBrinqNome.PlaceholderText = "Nome";
            txtBrinqNome.Size = new Size(355, 27);
            txtBrinqNome.TabIndex = 38;
            txtBrinqNome.Visible = false;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 566);
            Controls.Add(txtBrinqNome);
            Controls.Add(cbxBrinqTmn);
            Controls.Add(lblBrinqTmn);
            Controls.Add(cbxBrinqIdade);
            Controls.Add(lblBrinqIdade);
            Controls.Add(cbxBrinqTipo);
            Controls.Add(lblBrinqTipo);
            Controls.Add(cbxLivroEstado);
            Controls.Add(lblLivroEstado);
            Controls.Add(lblLivroGnr);
            Controls.Add(cbxLivroGenero);
            Controls.Add(txtLivroNome);
            Controls.Add(cbxEletroVolt);
            Controls.Add(lblEletroVolt);
            Controls.Add(lblEletroTipo);
            Controls.Add(rdbEletroTipo);
            Controls.Add(txtEletroNome);
            Controls.Add(lblRoupaDesc);
            Controls.Add(txtRoupaDesc);
            Controls.Add(cbxRoupaTipo);
            Controls.Add(lblRoupaTipo);
            Controls.Add(lblRoupaTmn);
            Controls.Add(cbxRoupaTmn);
            Controls.Add(lblRoupaGnr);
            Controls.Add(cbxRoupaGnr);
            Controls.Add(lblRoupaId);
            Controls.Add(txtRoupaId);
            Controls.Add(txtRoupaNome);
            Controls.Add(brn_confirmar);
            Controls.Add(btnCadastro);
            Controls.Add(cbxCategoria);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            Load += Cadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxCategoria;
        private Button btnCadastro;
        private Button brn_confirmar;
        private TextBox txtRoupaNome;
        private TextBox txtRoupaId;
        private ComboBox cbxRoupaGnr;
        private Label lblRoupaGnr;
        private Label lblRoupaTmn;
        private ComboBox cbxRoupaTmn;
        private Label lblRoupaTipo;
        private ComboBox cbxRoupaTipo;
        private TextBox txtRoupaDesc;
        private Label lblRoupaDesc;
        private TextBox txtEletroNome;
        private Label lblEletroTipo;
        private ComboBox rdbEletroTipo;
        private ComboBox cbxEletroVolt;
        private Label lblEletroVolt;
        private TextBox txtLivroNome;
        private Label lblLivroGnr;
        private ComboBox cbxLivroGenero;
        private ComboBox cbxLivroEstado;
        private Label lblLivroEstado;
        private Label lblRoupaId;
        private ComboBox cbxBrinqTipo;
        private Label lblBrinqTipo;
        private ComboBox cbxBrinqIdade;
        private Label lblBrinqIdade;
        private ComboBox cbxBrinqTmn;
        private Label lblBrinqTmn;
        private TextBox txtBrinqNome;
    }
}