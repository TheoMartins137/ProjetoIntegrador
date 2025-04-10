using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public class Produto
    {
        public Produto(string? nome, int id)
        {
            this.nome = nome;
            this.id = id;
        }

        public Produto() { }

        public string? nome { get; set; }
        public int id { get; set; }

        public static List<Produto> ListaProdutos =  new List<Produto>();
    }
}
