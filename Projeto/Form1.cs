namespace Projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cadastro form = new Cadastro();
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (rdb_teste1.Checked == true)
            {
                dataGridView1.DataSource = Pessoa.ListaPessoas;
            }
            else if (rdbTeste2.Checked == true)
            {
                dataGridView1.DataSource = Produto.ListaProdutos;
            }
        }
    }
}
