using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecaoStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f); //variavel se torna um Float Literal!

            foreach (var item in pilha)
            {
                Console.Write($" {item} ");
            }
            Console.WriteLine($"\nPop: {pilha.Pop()}");

            foreach (var item in pilha)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine($"\nPeek: {pilha.Peek()}");   //peek não remove da pilha ou fila
            Console.WriteLine(pilha.Count);

        }
    }
}
