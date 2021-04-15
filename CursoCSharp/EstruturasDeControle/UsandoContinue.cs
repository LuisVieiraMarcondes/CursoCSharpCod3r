using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class UsandoContinue
    {
        public static void Executar()
        {
            int intervalo = 50;
            Console.WriteLine("Numeros pares entre 1 e {0}!", intervalo);

            for (int i = 1; i <= intervalo; i++)
            {
                if (i % 2 == 1) //essa condição IF faz que o MOD( % ) de um número for 1(ímpar) ele será um número ímpar!
                {
                    continue;   //O continue, ele vai pra próxima repetição do laço FOR
                }

                Console.Write(i + " ");
            }
        }
    }
}
