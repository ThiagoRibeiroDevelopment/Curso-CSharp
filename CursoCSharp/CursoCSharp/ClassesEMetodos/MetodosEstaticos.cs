using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class MetodosEstaticos
    {
        public class CalculadoraEstatica
        {
            public static int Multiplicar(int a, int b)
            {
                return a * b;
            }
            public int Somar(int a, int b)
            {
                return a + b;
            }
        }
        public static void Executar()
        {
            //ISNTANCIA É FEITA EM CIMA DE UM OBJETO
            //nesse caso nao precisa instanciar pq o metodo Multiplicar do objeto CalculadoraEstatica eh estatico, 
            //pertencendo nao mais ao objeto e sim a classe, se o metodo nao tiver o static precisa instanciar
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);

            Console.WriteLine("Resultado: {0}: ",resultado);
            CalculadoraEstatica calculadora = new CalculadoraEstatica();
            Console.WriteLine(calculadora.Somar(2,2));
        }
    }
}
