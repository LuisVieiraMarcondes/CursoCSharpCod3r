using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            bool comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a Tv 50? {0}", comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou Sorvete? {0}", comprouSorvete);

            var ComprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou a tv 32? {0}", ComprouTv32);

            Console.WriteLine("Mais saudável? {0}", !comprouSorvete);


        }
    }
}
