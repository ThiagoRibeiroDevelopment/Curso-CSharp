using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); //F1 irá arredondar pra uma casa depois da virgula
            Console.WriteLine(valor.ToString("C")); //Currency (C) converte em moeda local
            Console.WriteLine(valor.ToString("P")); //P converte porcentagem

            CultureInfo cultura = new CultureInfo("en-US");
            //Converter o valor em moeda do local cultura criando acima
            Console.WriteLine(valor.ToString("C0", cultura)); //C0 esta convertento pra moeda sem nenhuma casa decimal

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); //ira preencher zeros a esquerda ate dar um total de 10 casas
        }
    }
}
