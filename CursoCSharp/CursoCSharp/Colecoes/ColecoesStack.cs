using System;
using System.Collections;

namespace CursoCSharp.Colecoes
{
    class ColecoesStack
    {
        public static void Executar()
        {
            var pilha = new Stack(); //Stack eh pilha

            pilha.Push(3); //push ádiciona elemento na pilha
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach (var item in pilha)
            {
                Console.Write($"{item} ");
            }
            //pop vai sacar o primeiro elemento da pilha e remover
            Console.WriteLine($"\nPop: {pilha.Pop()}");

            foreach (var item in pilha)
            {
                Console.Write($"{item} ");
            }
            //Peek mostra o ultimo elemento da pilha mas nao remove
            Console.WriteLine($"\nPeek: {pilha.Peek()}"); 
            Console.WriteLine(pilha.Count);
        }
    }
}
