﻿namespace Banco_de_Dados
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
            btnCadastro = new Button();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            txtTelefone = new TextBox();
            lstLista = new ListView();
            btnPesquisa = new Button();
            cbxIdade = new ComboBox();
            cbxGenero = new ComboBox();
            SuspendLayout();
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(65, 271);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(125, 29);
            btnCadastro.TabIndex = 0;
            btnCadastro.Text = "Cadastrar";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(65, 92);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome:";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 1;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(65, 149);
            txtIdade.Name = "txtIdade";
            txtIdade.PlaceholderText = "Idade:";
            txtIdade.Size = new Size(125, 27);
            txtIdade.TabIndex = 2;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(65, 210);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Gênero:";
            txtTelefone.Size = new Size(125, 27);
            txtTelefone.TabIndex = 3;
            // 
            // lstLista
            // 
            lstLista.Location = new Point(294, 93);
            lstLista.Name = "lstLista";
            lstLista.Size = new Size(952, 312);
            lstLista.TabIndex = 4;
            lstLista.UseCompatibleStateImageBehavior = false;
            lstLista.SelectedIndexChanged += lstLista_SelectedIndexChanged;
            // 
            // btnPesquisa
            // 
            btnPesquisa.Location = new Point(742, 47);
            btnPesquisa.Name = "btnPesquisa";
            btnPesquisa.Size = new Size(94, 29);
            btnPesquisa.TabIndex = 5;
            btnPesquisa.Text = "Pesquisar";
            btnPesquisa.UseVisualStyleBackColor = true;
            btnPesquisa.Click += btnPesquisa_Click;
            // 
            // cbxIdade
            // 
            cbxIdade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxIdade.FormattingEnabled = true;
            cbxIdade.Items.AddRange(new object[] { "Menor de 18 anos", "Maior de 18 anos" });
            cbxIdade.Location = new Point(585, 47);
            cbxIdade.Name = "cbxIdade";
            cbxIdade.Size = new Size(151, 28);
            cbxIdade.TabIndex = 6;
            // 
            // cbxGenero
            // 
            cbxGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxGenero.FormattingEnabled = true;
            cbxGenero.Items.AddRange(new object[] { "Masculino", "Feminino" });
            cbxGenero.Location = new Point(428, 47);
            cbxGenero.Name = "cbxGenero";
            cbxGenero.Size = new Size(151, 28);
            cbxGenero.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 417);
            Controls.Add(cbxGenero);
            Controls.Add(cbxIdade);
            Controls.Add(btnPesquisa);
            Controls.Add(lstLista);
            Controls.Add(txtTelefone);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(btnCadastro);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastro;
        private TextBox txtNome;
        private TextBox txtIdade;
        private TextBox txtTelefone;
        private ListView lstLista;
        private Button btnPesquisa;
        private ComboBox cbxIdade;
        private ComboBox cbxGenero;
    }
}
