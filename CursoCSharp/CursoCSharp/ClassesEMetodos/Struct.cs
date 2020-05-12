using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    interface Ponto 
    {
        void MoverNaDiagonal(int delta); //método de uma inteface eh sempre publico por padrao
    }

    struct Coordenada: Ponto // : significa q essa struct é aderente a inferca Ponto
    {
        public int X;
        public int Y;

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;

        }
        public void MoverNaDiagonal(int delta)
        {
            X += delta;
            Y += delta;
        }
    }

    class ExempploStruct
    {
        public static void Executar()
        {
            Coordenada coordenadaInicial; //como o metodo Coordenda é do tipo struct, nao precisa instanciar
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            Console.WriteLine("Coordenada Inicial:");
            Console.WriteLine("X = {0}", coordenadaInicial.X);
            Console.WriteLine("Y = {0}", coordenadaInicial.Y);

            var coordenadaFinal = new Coordenada(x: 9, y: 1);
            coordenadaFinal.MoverNaDiagonal(10);

            Console.WriteLine("Coordenada Final:");
            Console.WriteLine("X = {0}", coordenadaFinal.X);
            Console.WriteLine("Y = {0}", coordenadaFinal.Y);

        }
    }
}
