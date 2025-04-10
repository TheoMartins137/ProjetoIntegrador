namespace Projeto
{
    partial class Teste
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
            btnConfirm = new Button();
            cbxCategoria = new ComboBox();
            cbxTamanho = new ComboBox();
            cbxGenero = new ComboBox();
            cbxTipoEletro = new ComboBox();
            comboBox2 = new ComboBox();
            cbxIntegridade = new ComboBox();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(668, 136);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(120, 28);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "Testar";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // cbxCategoria
            // 
            cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Items.AddRange(new object[] { "Roupa", "Eletrodomesticos" });
            cbxCategoria.Location = new Point(40, 136);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(151, 28);
            cbxCategoria.TabIndex = 1;
            // 
            // cbxTamanho
            // 
            cbxTamanho.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTamanho.Enabled = false;
            cbxTamanho.FormattingEnabled = true;
            cbxTamanho.Items.AddRange(new object[] { "GG", "G", "M", "P", "PP" });
            cbxTamanho.Location = new Point(237, 136);
            cbxTamanho.Name = "cbxTamanho";
            cbxTamanho.Size = new Size(151, 28);
            cbxTamanho.TabIndex = 2;
            cbxTamanho.Visible = false;
            // 
            // cbxGenero
            // 
            cbxGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxGenero.Enabled = false;
            cbxGenero.FormattingEnabled = true;
            cbxGenero.Items.AddRange(new object[] { "Masculino", "Feminino", "Infantil" });
            cbxGenero.Location = new Point(443, 136);
            cbxGenero.Name = "cbxGenero";
            cbxGenero.Size = new Size(151, 28);
            cbxGenero.TabIndex = 3;
            cbxGenero.Visible = false;
            // 
            // cbxTipoEletro
            // 
            cbxTipoEletro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoEletro.Enabled = false;
            cbxTipoEletro.FormattingEnabled = true;
            cbxTipoEletro.Items.AddRange(new object[] { "Geladeira", "Fogão", "Micro-ondas", "AirFryer" });
            cbxTipoEletro.Location = new Point(237, 136);
            cbxTipoEletro.Name = "cbxTipoEletro";
            cbxTipoEletro.Size = new Size(151, 28);
            cbxTipoEletro.TabIndex = 4;
            cbxTipoEletro.Visible = false;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Enabled = false;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "GG", "G", "M", "P", "PP" });
            comboBox2.Location = new Point(443, 136);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 5;
            comboBox2.Visible = false;
            // 
            // cbxIntegridade
            // 
            cbxIntegridade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxIntegridade.Enabled = false;
            cbxIntegridade.FormattingEnabled = true;
            cbxIntegridade.Items.AddRange(new object[] { "Conservado", "Semi-novo", "Mais pra lá do que pra cá", "Capenga", "Só por reza" });
            cbxIntegridade.Location = new Point(443, 136);
            cbxIntegridade.Name = "cbxIntegridade";
            cbxIntegridade.Size = new Size(151, 28);
            cbxIntegridade.TabIndex = 6;
            cbxIntegridade.Visible = false;
            cbxIntegridade.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // Teste
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbxIntegridade);
            Controls.Add(comboBox2);
            Controls.Add(cbxTipoEletro);
            Controls.Add(cbxGenero);
            Controls.Add(cbxTamanho);
            Controls.Add(cbxCategoria);
            Controls.Add(btnConfirm);
            Name = "Teste";
            Text = "Teste";
            ResumeLayout(false);
        }

        #endregion

        private Button btnConfirm;
        private ComboBox cbxCategoria;
        private ComboBox cbxTamanho;
        private ComboBox cbxGenero;
        private ComboBox cbxTipoEletro;
        private ComboBox comboBox2;
        private ComboBox cbxIntegridade;
    }
}