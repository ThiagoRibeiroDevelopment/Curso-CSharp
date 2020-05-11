using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class LendoDadosDoConsole
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu name? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o seu salario?");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //o CultureInfo.InvariantCulture serve para globalizar pontos e virgulas para numeros decimais

            Console.WriteLine($"{nome}, {idade}, R${salario}");

        }
    }
}
