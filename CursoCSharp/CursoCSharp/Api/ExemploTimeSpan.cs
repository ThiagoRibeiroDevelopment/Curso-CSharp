﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Api
{
    class ExemploTimeSpan
    {
        public static void Executar()
        {
            var intervalo = new TimeSpan(days: 10, hours: 20, minutes: 30, seconds: 40);
            //podia ter colocado direto var intervalo = new TimeSpan(10, 20, 30, 40);
            Console.WriteLine(intervalo);

            Console.WriteLine("Minutos: " + intervalo.Minutes);
            Console.WriteLine("Intervalo em Minutos: " + intervalo.TotalMinutes);

            var largada = DateTime.Now;
            var chegada = DateTime.Now.AddMinutes(15);

            var tempo = chegada - largada;

            Console.WriteLine("Duração: " + tempo);

            Console.WriteLine(intervalo.Add(TimeSpan.FromMinutes(8))); //acrescentou 8 minuto
            //subtrair 8 min do original,sem mexer no que foi somado
            Console.WriteLine(intervalo.Subtract(TimeSpan.FromMinutes(8)));
            Console.WriteLine(intervalo); //so pra mostrar que nao muda o original

            Console.WriteLine("ToString 1: " + intervalo.ToString("g")); //sem os segundos
            Console.WriteLine("ToString 2: " + intervalo.ToString("G"));//com os segundos
            //colocar ponto no lugar de : entre hora e min utilizando o "c"
            Console.WriteLine("ToString 3: " + intervalo.ToString("c"));

            //Converter uma string pra uma TimeSpan usando Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03").TotalMilliseconds);
        }
    }
}
