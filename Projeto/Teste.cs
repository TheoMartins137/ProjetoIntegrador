namespace Projeto
{
    public partial class Teste : Form
    {
        public Teste()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cbxCategoria.Text == "Roupa")
            {
                cbxTamanho.Visible = true;
                cbxGenero.Visible = true;
                cbxTamanho.Enabled = true;
                cbxGenero.Enabled = true;

                cbxTipoEletro.Visible = false;
                cbxIntegridade.Visible = false;
                cbxTipoEletro.Enabled = false;
                cbxIntegridade.Enabled = false;

            }
            else if (cbxCategoria.Text == "Eletrodomesticos")
            {
                cbxTipoEletro.Visible = true;
                cbxIntegridade.Visible = true;
                cbxTipoEletro.Enabled = true;
                cbxIntegridade.Enabled = true;

                cbxTamanho.Visible = false;
                cbxGenero.Visible = false;
                cbxTamanho.Enabled = false;
                cbxGenero.Enabled = false;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
