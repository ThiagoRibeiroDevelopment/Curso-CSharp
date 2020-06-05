using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class AmigoProximo
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("AmigoProximo...");

            Console.WriteLine(amiga.InfoPublica);
            //CorDoOlho só é acessivel por herança
            // Console.WriteLine(amiga.CorDoOlho);

            Console.WriteLine(amiga.NumeroCelular);
            Console.WriteLine(amiga.JeitoDeFalar);//JeitoDeFalar possivel por ser internal (dentro do projeto)

            //SegredoFamilia tbm so por herança
            // Console.WriteLine(amiga.SegredoFamilia);
            // Console.WriteLine(amiga.UsaMuitoPhotoshop);
        }
    }
}
