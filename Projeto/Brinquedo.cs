namespace Projeto
{
    public class Brinquedo
    {
        public Brinquedo(string? id, string? nome, string? descricao, string? tipo, string? faixaetaria, string? tamanho)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.tipo = tipo;
            this.faixaetaria = faixaetaria;
            this.tamanho = tamanho;
        }

        public Brinquedo() { }

        public string? id { get; set; }
        public string? nome { get; set; }
        public string? descricao { get; set; }
        public string? tipo { get; set; }
        public string? faixaetaria { get; set; }
        public string? tamanho { get; set; }

        public static List<Brinquedo> ListaBrinquedos = new List<Brinquedo>();
    }
}
