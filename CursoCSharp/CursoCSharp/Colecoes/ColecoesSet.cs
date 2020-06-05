using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Throne", 49.9);
            //HashSet é uma estrutura nao indexada, entao RemoveAt, IndexOf e LastIndexOf nao funcionam
            //List aceita repetição de um msm item na lista, ja o HashSet NAO aceita
            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10),
                new Produto("Poster", 10)
            };

            //O List tbm tem o UnionWith, mas ele é mais usado em estruturas nao indexadas, q é o HashSet
            carrinho.UnionWith(combo); //UnionWith do HashSet faz igual o AddRange no List, add varios elementos no Array
            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
                // Console.Write(carrinho.IndexOf(item)); 
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            //o tamanho da lista impressa abaixo eh o msmo de cima, pq HashSet nao aceita repetição, ou seja
            //ele nao insere como um novo
            Console.WriteLine(carrinho.Count);
            // Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}
