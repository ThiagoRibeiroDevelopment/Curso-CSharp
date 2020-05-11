using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            //A inferencia dedus que nome é string pelo fato dela estar recendo um conjunto de caracter
            var nome = "Thiago";
            Console.WriteLine(nome);

            var idade = 30; //Inferencia do tipo int
            Console.WriteLine("Idade é " +idade);
        }
    }
}
