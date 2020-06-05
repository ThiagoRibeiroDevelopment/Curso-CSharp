using System;

namespace CursoCSharp.Api
{
    class ExemploDateTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(year: 2030, month: 2, day: 6);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            // Sem horas
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            // Com horas
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);
            Console.WriteLine("Hora: " + diaAtual.Hour);
            Console.WriteLine("Minutes: " + diaAtual.Minute);

            var amanha = diaAtual.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = diaAtual.AddDays(-1);
            Console.WriteLine(ontem);

            Console.WriteLine(diaAtual.ToString("dd")); //retorna apenas o dia atual
            Console.WriteLine(diaAtual.ToString("d")); //retorna dia mes ano
            Console.WriteLine(diaAtual.ToString("D"));//retorna o dia da semana, dia do mess, mes e ano
            Console.WriteLine(diaAtual.ToString("g"));//retorna apena o dia atual com a hora e min
            Console.WriteLine(diaAtual.ToString("G"));//retorna apena o dia com horas, min e segundos
            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:mm"));//retorna no formato padrão
        }
    }
}
