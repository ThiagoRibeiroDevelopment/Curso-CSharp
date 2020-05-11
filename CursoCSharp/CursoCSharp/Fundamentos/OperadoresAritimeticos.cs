using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritimeticos
    {
        public static void Executar()
        {
            var preco = 1000.0;
            var imposto = 300;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalDesconto = total - total * desconto;
            Console.WriteLine("O preço final é {0}", totalDesconto);

            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2); //Pow esta calcula a potencia de altura elevada a potencia 2
            Console.WriteLine("O IMC é {0}", imc.ToString("F1"));

            int par = 24;
            int impar = 25;
            Console.WriteLine("{0}/2 tem resto {1}", par, par%2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar%2); //o %2 pega o resto e esta mostrando o seu resto
        }
    }
}
