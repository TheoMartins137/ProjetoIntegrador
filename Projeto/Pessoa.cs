using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public class Pessoa
    {
        public Pessoa(string? nome, int id)
        {
            this.nome = nome;
            this.id = id;
        }

        public Pessoa() { }

        public string? nome { get; set; }
        public int id { get; set; }

        public static List<Pessoa> ListaPessoas = new List<Pessoa>(); 
    }
}
