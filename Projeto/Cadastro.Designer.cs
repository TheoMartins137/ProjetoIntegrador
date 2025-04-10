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
            txtNome = new TextBox();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // cbxCategoria
            // 
            cbxCategoria.AllowDrop = true;
            cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Items.AddRange(new object[] { "Pessoa", "Produto" });
            cbxCategoria.Location = new Point(269, 64);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(151, 28);
            cbxCategoria.TabIndex = 0;
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(96, 182);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(125, 29);
            btnCadastro.TabIndex = 1;
            btnCadastro.Text = "Cadastrar";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(96, 64);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "NOME";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.Location = new Point(96, 128);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "ID";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 3;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 450);
            Controls.Add(txtId);
            Controls.Add(txtNome);
            Controls.Add(btnCadastro);
            Controls.Add(cbxCategoria);
            Name = "Cadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxCategoria;
        private Button btnCadastro;
        private TextBox txtNome;
        private TextBox txtId;
    }
}