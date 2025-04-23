namespace Projeto
{
    public class Roupa
    {
        public Roupa(string? id, string? nome, string? descricao, string? tamanho, string? genero, string? tipo)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.tamanho = tamanho;
            this.genero = genero;
            this.tipo = tipo;
        }

        public Roupa() { }

        public string? id { get; set; }
        public string? nome { get; set; }
        public string? descricao { get; set; }
        public string? tamanho { get; set; }
        public string? genero { get; set; }
        public string? tipo { get; set; }

        public static List<Roupa> ListaRoupa = new List<Roupa>();

    }
}
