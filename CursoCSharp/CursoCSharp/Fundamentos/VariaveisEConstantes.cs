using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;
            double area = PI * raio * raio;

            Console.WriteLine(area);
            string result = "Área é: ";
            Console.WriteLine(result,  +area);

            //Tipos internos

            bool estachovendo = true;
            Console.WriteLine("Esta chovendo " + estachovendo);

            byte idade = 30;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Menor valor no sbyte " +saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Maximo valor do short " + salario);

            int menorvalor = int.MinValue;
            Console.WriteLine("Menor valor do inteiro " +menorvalor);

            //uint é o int sem a parte negativa
            uint populacaoBrasileira = 207_600_000; // Eh possivel colocar o _ para melhorar visualizacao sem dar erro
            Console.WriteLine("Populacao no Brasil em uint: " +populacaoBrasileira);

            long menorValorLong = long.MinValue;
            long maiorValorLong = long.MaxValue;
            Console.WriteLine("Maior valor de long é " + menorValorLong + " e menor valor de long é " +maiorValorLong);

            //float precoComputador = 1299.99f; //float armazena 4 byte e double 8 byte

            //Decimal armazena o dobro de valores que o long
            decimal distanciaEntreEtrelas = decimal.MaxValue;
            decimal menorValorDecimal = decimal.MinValue;
            Console.WriteLine("O menor valor de decimal é " +menorValorDecimal +" e o maior decimal é " +distanciaEntreEtrelas);

            char letra = 'a';
            Console.WriteLine("Letra " + letra);

            string nome = "Thiago";
            Console.WriteLine("Nome: " + nome);
        }
    }
}
