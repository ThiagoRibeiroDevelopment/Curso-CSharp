using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados
{
    class Nullables
    {
        public static void Executar()
        {
            Nullable<int> num1 = null; //Nullable usado pra valor null
            int? num2 = null; //se nao colocar ? nao aceita converter o nulo em int

            if (num1.HasValue) //HasValue pergunta se tem valor
            {
                Console.WriteLine("Valor de num: {0}", num1);
            }
            else
            {
                Console.WriteLine("A variável não possui valor.");
            }
            // ?? usado para: se num1 tiver nulo seta ele como 1000, se nao tiver nulo valor recebe num1
            int valor = num1 ?? 1000;
            Console.WriteLine(valor);

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();//se tiver valor retorna valor, se nao tiver retorna false
            Console.WriteLine(resultado);

            try
            {
                int x = num1.GetValueOrDefault();
                int y = num2.GetValueOrDefault();
                Console.WriteLine(x + y);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
