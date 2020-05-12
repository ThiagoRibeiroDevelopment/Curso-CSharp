using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        //Colocando um atributo static
        public static double Desconto;
        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }
        public Produto()
        {

        }
        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }
    class AtributosEstaticos
    {
        public static void Executar()
        {
            var produto1 = new Produto("caneta", 3.2, 0);

            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 5.3
            };
            //Com o atributo Desconto sendo estatico, é preciso atribuir um valor a ele fora
            //da instancia produto2
            Produto.Desconto = 0.30;
            Console.WriteLine("Preço com dsconto do produto 1: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto do produto 2: {0}", produto2.CalcularDesconto());

            Produto.Desconto = 0.20;
            Console.WriteLine("Preço com desconto do produto 1: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto do produto 2: {0}", produto2.CalcularDesconto());
        }
    }
}
