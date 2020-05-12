using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>(); //<> termo usado pra dizer que é Generic de Queue em Collection

            fila.Enqueue("Fulano"); //Enqueue significa enfileirar
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek()); //Peek ira pega o primeiro elemento ta fila pra exibir
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue()); //Dequeue tira o primeiro elemento da fila
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("item"));
            Console.WriteLine(salada.Contains("Item"));
        }
    }
}
