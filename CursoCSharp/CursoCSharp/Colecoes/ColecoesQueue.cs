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

            Console.WriteLine(fila.Peek()); //Peek ira pega o primeiro elemento da fila pra exibir
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue()); //Dequeue tira o primeiro elemento da fila
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue(); // Queue() pertence a Collection e Queue<>() a Collection.Generic
            salada.Enqueue(3);
            salada.Enqueue("Item"); //Item maisculo
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            //Contains retorna true ou false (Contem o elemento na fila???)
            Console.WriteLine(salada.Contains("item")); //item minuscolo
            Console.WriteLine(salada.Contains("Item")); //Item maisculo
        }
    }
}
