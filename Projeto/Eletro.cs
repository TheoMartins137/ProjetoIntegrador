namespace Projeto
{
    public class Eletro
    {
        public Eletro(string? id, string? nome, string? descricao, string? tipo, string? voltagem)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.tipo = tipo;
            this.voltagem = voltagem;
        }

        public Eletro() { }

        public string? id { get; set; }
        public string? nome { get; set; }
        public string? descricao { get; set; }
        public string? tipo { get; set; }
        public string? voltagem { get; set; }

        public static List<Eletro> ListaEletro = new List<Eletro>();
    }
}
