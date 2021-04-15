using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosPorReferencia
    {   
        public static void AlterarRef(ref int numero)
        {
            numero = numero + 1000;
        }
        public static void AlterarOut(out int numero)
        {
            numero = 0;
            numero = numero + 15;
        }
        public static void Executar()
        {
            int a = 3;
            AlterarRef(ref a);  //aqui vc altera o resultado referenciando 
            Console.WriteLine(a);

            //int b = 2;
            AlterarOut(out int b); //o Out é unidirecional, 
            Console.WriteLine(b);

        }
    }
}
