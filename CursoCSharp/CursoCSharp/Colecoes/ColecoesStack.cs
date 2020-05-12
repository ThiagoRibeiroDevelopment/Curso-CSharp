using System;
using System.Collections;
using System.Text;

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

            Console.WriteLine($"\nPop: {pilha.Pop()}"); //pop vai sacar o primeiro elemento da pilha e remover

            foreach (var item in pilha)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nPeek: {pilha.Peek()}"); //Peek mostra o ultimo elemento da pilha mas nao remove
            Console.WriteLine(pilha.Count);
        }
    }
}
