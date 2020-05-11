using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            double nota = 9.7;
            int notaTruncada = (int)nota; //(int) isso é conhecido como cash, esta fazendo um cash para converter double em int
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Idade usando Convert.ToInt32 : {0}", idadeInteiro);

            Console.WriteLine("Digite o primeiro número:");
            string palavra = Console.ReadLine();
            int.TryParse(palavra, out int numero); //tente converter palava e jogue dentro de inteiro numero, se nao conseguir, return 0
            Console.WriteLine("Saida: {0}", numero);

            Console.WriteLine("Digite o segundo número:");
            int.TryParse(Console.ReadLine(), out int numero2); //tente converter palava e jogue dentro de inteiro numero, se nao conseguir, return 0
            Console.WriteLine("Saida: {0}", numero2);
        }
    }
}
