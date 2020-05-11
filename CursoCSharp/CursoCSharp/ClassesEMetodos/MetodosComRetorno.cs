using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraComum {
        //public int Somar(double a, int b)
        //{
        //    return (int)a + b; //necessario fazer o cash em a para int pq o metodo Somar return um int
        //}
        //public int Somar(int a, double b)
        //{
        //    return a + (int)b; //necessario fazer o cash em b para int pq o metodo Somar return um int
        //}
        public int Somar(int a, int b)
        {
            return a + b;
        }
        public int Subtrair (int a, int b)
        {
            return a - b;
        }
        public int Multiplicar (int a, int b)
        {
            return a * b;
        }
    }

    class CalculadoraCadeia
    {
        int memoria;
        
        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this; // necessario colocar o this para que retorne o proprio metodo, no caso o metodo CalculadoraCadeia
        }
        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }
        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }
        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }
        public int Resultado()
        {
            return memoria;
        }
    }
    class MetodosComRetorno
    {
        public static void Executar()
        {
            CalculadoraComum calculadoraComum = new CalculadoraComum();
            var resultadoSomar = calculadoraComum.Somar(5, 3);
            var resultadoSubtrair = calculadoraComum.Subtrair(5, 3);
            //var resultadoMultiplicar = calculadoraComum.Multiplicar(5, 3);

            Console.WriteLine($"Resultados: Soma {resultadoSomar}" +
                $" Subtraçao {resultadoSubtrair}" +
                $" Multiplicação {calculadoraComum.Multiplicar(5, 3)}");

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();

            double resultado = calculadoraCadeia.Somar(3).Multiplicar(2).Resultado();
            Console.WriteLine(resultado);            
        }
    }
}
