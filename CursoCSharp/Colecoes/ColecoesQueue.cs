using System;
using System.Collections.Generic;
using System.Collections;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();     //Estou amarrando que todos os items da minha fila será string

            fila.Enqueue("Fulano");         //Enqueue ENFILERA & Dequeueu DESENFILERA!
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue());  //Desenfilera
            Console.WriteLine(fila.Count);      //conta quantos indices 

            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);

            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("item"));
            Console.WriteLine(salada.Contains("Item"));

        }
    }
}
