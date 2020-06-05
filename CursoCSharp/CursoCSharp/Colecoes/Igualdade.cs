using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2; //Atribuição por referencia

            //Comparando espaço de memoria
            Console.WriteLine(p1 == p2); //false pq eles apontam pra memorias diferentes
            Console.WriteLine(p3 == p2); //true pq apontam pro mesmo espaço de memoria

            //Equals ira comparar se o msmo local de memoria p1 eh o msmo local de memoria p2
            //para que o Equals compare oq tem dentro do espaço de memoria, eh preciso fazer um override
            //de Equals dentro da classe Produto comparando Nome e preço
            Console.WriteLine(p1.Equals(p2));
        }
    }
}
