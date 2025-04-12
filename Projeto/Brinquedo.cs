﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public class Brinquedo
    {
        public Brinquedo(int? id, string? nome, string? descricao, string? tipo, string? faixaetaria, string? tamanho)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.tipo = tipo;
            this.faixaetaria = faixaetaria;
            this.tamanho = tamanho;
        }

        public Brinquedo() { }

        public int? id { get; set; }
        public string? nome { get; set; }
        public string? descricao { get; set; }
        public string? tipo { get; set; }
        public string? faixaetaria { get; set; }
        public string? tamanho { get; set; }

        public static List<Brinquedo> ListaBrinquedos = new List<Brinquedo>();
    }
}
