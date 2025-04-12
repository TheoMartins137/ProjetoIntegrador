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

        private void btnCadastro_Click(object sender, EventArgs e)
        {


        }

        private void brn_confirmar_Click(object sender, EventArgs e)
        {
            if (cbxCategoria.Text == "Roupas")
            {
                MostrarRoupa();
                EsconderEletro();
                EsconderLivro();
                EsconderBrinq();
            }
            else if (cbxCategoria.Text == "Eletrodomesticos")
            {
                MostrarEletro();
                EsconderRoupa();
                EsconderLivro();
                EsconderBrinq();
            }
            else if (cbxCategoria.Text == "Livros")
            {
                MostrarLivro();
                EsconderRoupa();
                EsconderEletro();
                EsconderBrinq();
            }
            else if(cbxCategoria.Text == "Brinquedos")
            {
                MostrarBrinq();
                EsconderRoupa();
                EsconderEletro();
                EsconderLivro();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLivroDesc_Click(object sender, EventArgs e)
        {

        }
    }
}
