using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            bool executouTrabalho1 = true;
            var executouTrabalho2 = false;

            bool comprouTV50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a TV 50? {0}", comprouTV50);

            bool comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

            bool comprouTV32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou a TV 32? {0}", comprouTV32);

            Console.WriteLine("Mais saudável? {0}", !comprouSorvete);



        }
    }
}
