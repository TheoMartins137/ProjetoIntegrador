using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public class Eletro
    {
        public Eletro(int? id, string? nome, string? descricao, string? tipo, string? voltagem)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.tipo = tipo;
            this.voltagem = voltagem;
        }

        public Eletro() { }

        public int? id {  get; set; }
        public string? nome {  get; set; }
        public string? descricao {  get; set; }
        public string? tipo {  get; set; }
        public string? voltagem {  get; set; }

        public static List<Eletro> ListaEletro = new List<Eletro>();
    }
}
