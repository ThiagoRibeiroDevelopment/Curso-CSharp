using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            //Action nao tem retunr, eh uma void
            Action algoNoConsole = () => {
                Console.WriteLine("Lambda com C#!");
            };

            algoNoConsole();
            //Func<int> o tipo de retun da func é o ultimo parametro passado, aqui sendo int (so tem ele)
            Func<int> jogarDado = () => {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());
            //Func<int, string> o tipo de retun da func é o ultimo parametro passado, no caso string
            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));

            //Func<int, string> o tipo de retun da func é o ultimo parametro passado, no caso string
            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
                String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(1, 1, 2019));
        }
    }
}
