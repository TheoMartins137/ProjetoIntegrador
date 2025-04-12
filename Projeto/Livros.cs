using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public class Livros
    {
        public Livros(int? id, string? nome, string? genero, string? estado, string? descricao)
        {
            this.id = id;
            this.nome = nome;
            this.genero = genero;
            this.estado = estado;
            this.descricao = descricao;
        }

        public Livros () { }

        public int? id { get; set; }
        public string? nome { get; set; }
        public string? genero{ get; set; }
        public string? estado { get; set; }
        public string? descricao { get; set; }

        public static List<Livros> ListaLivros = new List<Livros> ();
    }
}
