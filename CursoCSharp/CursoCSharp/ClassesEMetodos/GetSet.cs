using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Moto
    {
        private string Marca;
        private string Modelo;
        private int Cilindrada;

        public Moto(string marca, string modelo, int cilindrada)
        {
            //Marca = marca;
            //Modelo = modelo;
            //Cilindrada = cilindrada;

            //Passando o set aqui para que chame os metodos Set para validar a cilindra no construtor
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }
        public Moto()
        {

        }
        public string GetMarca()
        {
            return Marca;
        }
        public void SetMarca(string marca)
        {
            Marca = marca;
        }
        public string GetModelo()
        {
            return Modelo;
        }
        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }
        public int GetCilindrada()
        {
            return Cilindrada;
        }
        public void SetCilindrada(int cilindrada)
        {
            //Primeira opcao
            //if (cilindrada > 0)
            //{
            //    Cilindrada = cilindrada;
            //}
            
            //Seguda opcao
            cilindrada = Math.Abs(cilindrada); //Math.Abs é o mudulo, entao se chegar valor - passa para +
            
            //Terceita opcao
            //Passar a variavel int cilindrada para o tipo unit (So aceita valor positivo)
        
        }
    }
    class GetSet
    {
        public static void Executar()
        {
            var moto1 = new Moto("Honda", "CB300", 300);
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(150);
            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo()
                + " " + moto2.GetCilindrada());
        }
    }
}
