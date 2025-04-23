using System.Data;
using MySql.Data.MySqlClient;

namespace Banco_de_Dados
{
    public partial class Form1 : Form
    {
        private string data_source = "datasource=localhost;username=root;password=Martinsfreitas8;database=teste";
        MySqlConnection Conexao;

        public Form1()
        {
            InitializeComponent();

            // configurações
            lstLista.View = View.Details;
            lstLista.LabelEdit = true;
            lstLista.AllowColumnReorder = true;
            lstLista.FullRowSelect = true;
            lstLista.GridLines = true;


            // Posição dos Cabeçalhos a serem exibidos na tela
            lstLista.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lstLista.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            lstLista.Columns.Add("Idade", 150, HorizontalAlignment.Left);
            lstLista.Columns.Add("Telefone", 150, HorizontalAlignment.Left);

            Carregar_Lista();
        }

        private void lstLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;

                cmd.Parameters.Clear();
                cmd.CommandText = "INSERT INTO pessoa(nome, idade, telefone)" +
                                  "VALUES (@nome, @idade, @telefone)";

                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@idade", txtIdade.Text);
                cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro Realizado com sucesso");

                txtNome.Clear();
                txtIdade.Clear();
                txtTelefone.Clear();

                Carregar_Lista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                Conexao.Close();
            }
                
        }

        private void Carregar_Lista()
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                string sql = "SELECT * FROM pessoa ORDER BY id ASC";

                MySqlCommand buscar = new MySqlCommand(sql, Conexao);
                MySqlDataReader reader = buscar.ExecuteReader();

                lstLista.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                        {
                         reader.GetInt32(0).ToString(),
                         reader.GetString(1),
                         reader.GetString(2),
                         reader.GetString(3),
                        };

                    var linha_list_view = new ListViewItem(row);
                    lstLista.Items.Add(linha_list_view);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}
