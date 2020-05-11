using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro
    {
        /// <summary>
        /// Classe com 3 atributos e dois construtores
        /// </summary>
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano)
        {
            //Se coloca-se o parametro modelo com m maisculo, teria q fazer this.Modelo = Modelo
            //this serve para dizer que this.Modelo refere-se ao objeto, e o sem refere-se ao parametro
            Modelo = modelo; 
            Fabricante = fabricante;
            Ano = ano;
        }
        public Carro()
        {

        }
    }
    class Construtores
    {
        public static void Executar()
        {
            var carro1 = new Carro(); //Construtor padrão
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2020;
            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            var carro2 = new Carro("Ka", "Ford", 2018); //Construtor personalizado
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

            var car3 = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2020
            };
            Console.WriteLine($"{car3.Fabricante} {car3.Modelo} {car3.Ano}");
        }
    }
}
