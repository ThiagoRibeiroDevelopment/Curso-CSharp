using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 10;
        public static void Executar()
        {
            //Criando instancia de DesafioAtributo
            DesafioAtributo acesso = new DesafioAtributo();
            Console.WriteLine(acesso.a);

        }
    }
}
