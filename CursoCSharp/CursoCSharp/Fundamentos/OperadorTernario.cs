using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 2.0;
            bool bomComportamento = true;
            //Operador ternário: 3 partees -> expressao, primeiro operando, segundo operado
            // ? usa como if e : else
            //se a expressao for verdadeira sera atribuido a resultado "Aprovado"
            //se a expressao for falsa, entao sera atribuido a resultado "Reprovado"
            string resultado = (nota >= 7.0 && bomComportamento) ? "Aprovado" : "Reprovado";
            Console.WriteLine("O aluno foi {0}", resultado);

        }
    }
}
