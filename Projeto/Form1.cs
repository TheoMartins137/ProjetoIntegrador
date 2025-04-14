namespace Projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void MostrarRoupa()
        {
            var controles = new Control[]
            {
                cbxRoupaGnr, cbxRoupaTipo, cbxRoupaTmn,
            };

            foreach (var controle in controles)
            {
                controle.Enabled = true;
                controle.Visible = true;
            }
        }

        public void EsconderRoupa()
        {
            var controles = new Control[]
            {
             cbxRoupaGnr, cbxRoupaTipo, cbxRoupaTmn,
            };

            foreach (var controle in controles)
            {
                controle.Enabled = false;
                controle.Visible = false;
            }
        }

        public void MostrarEletro()
        {
            var controles = new Control[]
            {
                cbxEletroTipo, cbxEletroVolt,
            };
            foreach (var controle in controles)
            {
                controle.Enabled = true;
                controle.Visible = true;
            }
        }

        public void EsconderEletro()
        {
            var controles = new Control[]
            {
                cbxEletroTipo, cbxEletroVolt,

            };
            foreach (var controle in controles)
            {
                controle.Enabled = false;
                controle.Visible = false;
            }
        }

        public void MostrarLivro()
        {
            var controles = new Control[]
            {
            cbxLivroEstado, cbxLivroGnr
            };

            foreach (var controle in controles)
            {
                controle.Enabled = true;
                controle.Visible = true;
            }
        }

        public void EsconderLivro()
        {
            var controles = new Control[]
            {
             cbxLivroEstado, cbxLivroGnr
            };

            foreach (var controle in controles)
            {
                controle.Enabled = false;
                controle.Visible = false;
            }
        }

        public void MostrarBrinq()
        {
            var controles = new Control[]
            {
            cbxBrinqTipo, cbxBrinqTmn, cbxBrinqIdade
            };

            foreach (var controle in controles)
            {
                controle.Enabled = true;
                controle.Visible = true;
            }
        }
        public void EsconderBrinq()
        {
            var controles = new Control[]
            {
             cbxBrinqTipo, cbxBrinqTmn, cbxBrinqIdade,
            };

            foreach (var controle in controles)
            {
                controle.Enabled = false;
                controle.Visible = false;
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cadastro form = new Cadastro();
            form.ShowDialog();
        }
        
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (cbxCategoria.Text == "Roupas")
            {
                EsconderBrinq();
                EsconderEletro();
                EsconderLivro();
                MostrarRoupa();

                string tamanhoSelecionado = cbxRoupaTmn.Text;
                string tipoSelecionado = cbxRoupaTipo.Text;
                string generoSelecionado = cbxRoupaGnr.Text;
                var filtrados = Roupa.ListaRoupa.Where(roupa => (string.IsNullOrEmpty(generoSelecionado) || roupa.genero == generoSelecionado) &&
                (string.IsNullOrEmpty(tipoSelecionado) || roupa.tipo == tipoSelecionado) &&
                (string.IsNullOrEmpty(tamanhoSelecionado) || roupa.tamanho == tamanhoSelecionado)).ToList();
                dataGridView1.DataSource = filtrados;
            }

            else if(cbxCategoria.Text == "Eletrodomesticos")
            {
                EsconderBrinq();
                EsconderLivro();
                EsconderRoupa();
                MostrarEletro();
                string voltagem = cbxEletroVolt.Text;
                string tipo = cbxEletroTipo.Text;

                var filtrados = Eletro.ListaEletro.Where(eletro => (string.IsNullOrEmpty(voltagem) || eletro.voltagem == voltagem) &&
                (string.IsNullOrEmpty(tipo) || eletro.tipo == tipo)).ToList();
                dataGridView1.DataSource = filtrados;
            }
            else if(cbxCategoria.Text == "Livros")
            {
                EsconderRoupa();
                EsconderBrinq();
                EsconderEletro();
                MostrarLivro();

                string estado = cbxLivroEstado.Text;
                string genero = cbxLivroGnr.Text;

                var filtrados = Livros.ListaLivros.Where(livro => (string.IsNullOrEmpty(estado) || livro.estado == estado) &&
                (string.IsNullOrEmpty(genero) || livro.genero == genero)).ToList();
                dataGridView1.DataSource = filtrados;
            }

            else if(cbxCategoria.Text == "Brinquedos")
            {
                EsconderEletro();
                EsconderLivro();
                EsconderRoupa();
                MostrarBrinq();

                string tipo = cbxBrinqTipo.Text;
                string tamanho = cbxBrinqTmn.Text;
                string idade = cbxBrinqIdade.Text;

                var filtrados = Brinquedo.ListaBrinquedos.Where(brinquedos => (string.IsNullOrEmpty(tipo) || brinquedos.tipo == tipo) &&
                (string.IsNullOrEmpty(tamanho) || brinquedos.tamanho == tamanho) &&
                (string.IsNullOrEmpty(idade) || brinquedos.faixaetaria == idade )).ToList();
                dataGridView1.DataSource = filtrados;
            }
        }

    }
}
