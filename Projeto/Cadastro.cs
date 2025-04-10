using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
           if (cbxCategoria.Text == "Produto")
           {
                Produto teste = new Produto();
                teste.nome = txtNome.Text;
                teste.id = Convert.ToInt32(txtId.Text);

                Produto.ListaProdutos.Add(teste);
           }
           if (cbxCategoria.Text == "Pessoa")
            {
                Pessoa pessoa = new Pessoa();
                pessoa.nome = txtNome.Text;
                pessoa.id = Convert.ToInt32(txtId.Text);

                Pessoa.ListaPessoas.Add(pessoa);
            }
        }
    }
}
