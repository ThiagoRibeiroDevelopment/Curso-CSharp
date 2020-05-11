using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar()
        {
            int num1 = 3;
            num1 += 10; //num1 = num1 + 10, pode fazer tbm: multiplicação, divisao(/), ......
            num1 -= 3; //num1 = num1 - 3
            
            int a = 1;
            int b = a; //Atribuição por valor
            a++; //a = a+1;
            b--; //b = b -1
            Console.WriteLine($"{a} {b}");

            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";
            dynamic d = c; //Atribuição por referencia
            d.nome = "Maria";
            Console.WriteLine(c.nome); //Eh impresso Maria, pq d.nome e c.nome ocupam msmo espaço de memoria, pq ocorreu uma atribuição por referência
            //e como mudou d.nome, entao consequentemente muda c.nome
        }
    }
}
