using System;

namespace CursoCSharp.OO
{
    public class Carro
    {
        //VelocidadeMaxima sera transmitida por herança, entao modificador sera do tipo protected
        protected readonly int VelocidadeMaxima; //readonly é pra deixar fixo o int VelocidadeMaxima
        int VelocidadeAtual; //como nao coloco nenhum modificador, entao por padrao fica sendo privado

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }
        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else
            {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }
        public virtual int Acelerar()
        { //o modificador virtual permite que o metodo seja sobreescrito em outro lugar
            return AlterarVelocidade(5);
        }

        public int Frear()
        {
            return AlterarVelocidade(-5);
        }
    }
    public class Uno : Carro
    {
        public Uno() : base(200) //base é para chamar o construtor base de Carro, ele espera 
                                 //receber uma Vel.max, que no caso setei como sendo 200 para o carro Uno
        {

        }
    }
    public class Ferrari : Carro
    {
        public Ferrari() : base(350) //Agora setei como sendo 350 para Ferrari
        {

        }

        public override int Acelerar() //override para deixar claro q esta sobreescrevendo um metodo
        {
            return AlterarVelocidade(15);
        }

        // Oculta o método da classe Pai
        public new int Frear() //o operador new permite sobreEscrever o metodo sem usar o virtual/override
        {
            return AlterarVelocidade(-15);
        }
    }

    class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());//ira frear com o metodo frear declarado em tipo Uno:Carro
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());//ira frear com o metodo frear declarado em tipo Ferrari
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Ferrari com tipo Carro...");
            Carro carro3 = new Ferrari(); // Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear()); //ira frear com o metodo frear declarado em tipo Carro
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("Uno com tipo Carro...");
            carro3 = new Uno(); // Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());//ira frear com o metodo frear declarado em tipo Carro
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }
    }
}

