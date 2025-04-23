namespace Projeto
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        public void MostrarRoupa()
        {
            var controles = new Control[]
            {
        txtRoupaDesc, txtRoupaId, txtRoupaNome,
        lblRoupaDesc, lblRoupaId, lblRoupaGnr,
        lblRoupaTipo, lblRoupaTmn,
        cbxRoupaGnr, cbxRoupaTipo, cbxRoupaTmn,
        btnCadastro
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
             txtRoupaNome, lblRoupaGnr,
             lblRoupaTipo, lblRoupaTmn,
             cbxRoupaGnr, cbxRoupaTipo, cbxRoupaTmn,
             btnCadastro
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
                txtRoupaDesc, txtRoupaId, txtEletroNome,
                lblRoupaDesc, lblRoupaId,lblEletroTipo, lblEletroVolt,
                rdbEletroTipo, cbxEletroVolt,
                btnCadastro

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
                txtEletroNome,
                lblEletroTipo, lblEletroVolt,
                rdbEletroTipo, cbxEletroVolt,
                btnCadastro

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
            txtRoupaDesc, txtRoupaId, txtLivroNome,
            lblRoupaDesc, lblRoupaId,lblLivroEstado, lblLivroGnr,
            cbxLivroEstado, cbxLivroGenero, btnCadastro
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
             txtLivroNome,
             lblLivroEstado, lblLivroGnr,
             cbxLivroEstado, cbxLivroGenero, btnCadastro
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
            txtRoupaDesc, txtRoupaId, txtBrinqNome,
            lblRoupaDesc, lblRoupaId,lblBrinqTipo, lblBrinqIdade, lblBrinqTmn,
            cbxBrinqTipo, cbxBrinqTmn, cbxBrinqIdade,
            btnCadastro
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
             txtBrinqNome,
             lblBrinqTipo, lblBrinqIdade, lblBrinqTmn,
             cbxBrinqTipo, cbxBrinqTmn, cbxBrinqIdade,
             btnCadastro
            };

            foreach (var controle in controles)
            {
                controle.Enabled = false;
                controle.Visible = false;
            }
        }

        public void LimparTudo()
        {
            var controles = new Control[]
            {
                txtBrinqNome, txtEletroNome, txtLivroNome, txtRoupaDesc, txtRoupaId, txtRoupaNome, rdbEletroTipo,
                cbxBrinqIdade, cbxBrinqTipo, cbxBrinqTmn, cbxEletroVolt, cbxLivroEstado, cbxLivroGenero,
                cbxRoupaGnr, cbxRoupaTipo, cbxRoupaTmn
            };
            foreach (var controle in controles)
            {
                if (controle is TextBox)
                {
                    ((TextBox)controle).Clear();
                }
                else if (controle is ComboBox)
                {
                    ((ComboBox)controle).SelectedIndex = -1;
                }
            }
        }

        public void Erro(string Mensagem)
        {
            MessageBox.Show(Mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {

            if (cbxCategoria.Text == "Roupas")
            {

                Roupa roupa = new Roupa();

                roupa.id = txtRoupaNome.Text;
                roupa.nome = txtRoupaNome.Text;
                roupa.descricao = txtRoupaDesc.Text;
                roupa.tamanho = cbxRoupaTmn.Text;
                roupa.genero = cbxRoupaGnr.Text;
                roupa.tipo = cbxRoupaTipo.Text;

                Roupa.ListaRoupa.Add(roupa);

                LimparTudo();
            }
            else if (cbxCategoria.Text == "Eletrodomesticos")
            {

                Eletro eletro = new Eletro();

                eletro.id = txtRoupaId.Text;
                eletro.nome = txtEletroNome.Text;
                eletro.descricao = txtRoupaDesc.Text;
                eletro.tipo = rdbEletroTipo.Text;
                eletro.voltagem = cbxEletroVolt.Text;

                Eletro.ListaEletro.Add(eletro);
                LimparTudo();

            }
            else if (cbxCategoria.Text == "Livros")
            {


                Livros livro = new Livros();

                livro.id = txtRoupaId.Text;
                livro.nome = txtRoupaNome.Text;
                livro.genero = cbxLivroGenero.Text;
                livro.estado = cbxLivroEstado.Text;
                livro.descricao = txtRoupaDesc.Text;

                Livros.ListaLivros.Add(livro);

                LimparTudo();

            }
            else if (cbxCategoria.Text == "Brinquedos")
            {

                Brinquedo brinquedo = new Brinquedo();

                brinquedo.id = txtRoupaId.Text;
                brinquedo.nome = txtBrinqNome.Text;
                brinquedo.descricao = txtRoupaDesc.Text;
                brinquedo.tipo = cbxBrinqTipo.Text;
                brinquedo.faixaetaria = cbxBrinqIdade.Text;
                brinquedo.tamanho = cbxBrinqTmn.Text;

                Brinquedo.ListaBrinquedos.Add(brinquedo);
                LimparTudo();

            }
        }

        private void brn_confirmar_Click(object sender, EventArgs e)
        {
            if (cbxCategoria.Text == "Roupas")
            {
                EsconderEletro();
                EsconderLivro();
                EsconderBrinq();
                MostrarRoupa();
            }
            else if (cbxCategoria.Text == "Eletrodomesticos")
            {
                EsconderRoupa();
                EsconderLivro();
                EsconderBrinq();
                MostrarEletro();
            }
            else if (cbxCategoria.Text == "Livros")
            {
                EsconderRoupa();
                EsconderEletro();
                EsconderBrinq();
                MostrarLivro();
            }
            else if (cbxCategoria.Text == "Brinquedos")
            {
                EsconderRoupa();
                EsconderEletro();
                EsconderLivro();
                MostrarBrinq();
            }
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
        }
    }
}
