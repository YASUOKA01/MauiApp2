using System;
using System.Collections.Generic;

namespace MauiApp2
{
    internal class Produto
    {
        public decimal Preco { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }

        // Lista estática para armazenar os produtos sem perder os dados
        public static List<Produto> Lista { get; } = new List<Produto>
        {
            new Produto() { Nome = "Buzina", Preco = 300, Categoria = "Acessórios" },
            new Produto() { Nome = "Mouse", Preco = 30, Categoria = "Informática" },
            new Produto() { Nome = "Paçoca", Preco = 3, Categoria = "Alimento" },
            new Produto() { Nome = "Notebook", Preco = 3000, Categoria = "Informática" },
            new Produto() { Nome = "Moto", Preco = 30000, Categoria = "Automóvel" }
        };
    }
}
