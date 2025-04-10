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
            rdb_teste1 = new RadioButton();
            groupBox1 = new GroupBox();
            rdbTeste4 = new RadioButton();
            rdbTeste3 = new RadioButton();
            rdbTeste2 = new RadioButton();
            btnCadastro = new Button();
            btnAtualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(920, 433);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // rdb_teste1
            // 
            rdb_teste1.AutoSize = true;
            rdb_teste1.Location = new Point(6, 26);
            rdb_teste1.Name = "rdb_teste1";
            rdb_teste1.Size = new Size(72, 24);
            rdb_teste1.TabIndex = 1;
            rdb_teste1.TabStop = true;
            rdb_teste1.Text = "Teste1";
            rdb_teste1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbTeste4);
            groupBox1.Controls.Add(rdbTeste3);
            groupBox1.Controls.Add(rdbTeste2);
            groupBox1.Controls.Add(rdb_teste1);
            groupBox1.Location = new Point(390, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 90);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // rdbTeste4
            // 
            rdbTeste4.AutoSize = true;
            rdbTeste4.Location = new Point(127, 56);
            rdbTeste4.Name = "rdbTeste4";
            rdbTeste4.Size = new Size(72, 24);
            rdbTeste4.TabIndex = 5;
            rdbTeste4.TabStop = true;
            rdbTeste4.Text = "Teste4";
            rdbTeste4.UseVisualStyleBackColor = true;
            // 
            // rdbTeste3
            // 
            rdbTeste3.AutoSize = true;
            rdbTeste3.Location = new Point(127, 26);
            rdbTeste3.Name = "rdbTeste3";
            rdbTeste3.Size = new Size(72, 24);
            rdbTeste3.TabIndex = 4;
            rdbTeste3.TabStop = true;
            rdbTeste3.Text = "Teste3";
            rdbTeste3.UseVisualStyleBackColor = true;
            // 
            // rdbTeste2
            // 
            rdbTeste2.AutoSize = true;
            rdbTeste2.Location = new Point(6, 60);
            rdbTeste2.Name = "rdbTeste2";
            rdbTeste2.Size = new Size(72, 24);
            rdbTeste2.TabIndex = 3;
            rdbTeste2.TabStop = true;
            rdbTeste2.Text = "Teste2";
            rdbTeste2.UseVisualStyleBackColor = true;
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
            btnAtualizar.Location = new Point(815, 26);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(117, 66);
            btnAtualizar.TabIndex = 4;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 553);
            Controls.Add(btnAtualizar);
            Controls.Add(btnCadastro);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private RadioButton rdb_teste1;
        private GroupBox groupBox1;
        private RadioButton rdbTeste4;
        private RadioButton rdbTeste3;
        private RadioButton rdbTeste2;
        private Button btnCadastro;
        private Button btnAtualizar;
    }
}
