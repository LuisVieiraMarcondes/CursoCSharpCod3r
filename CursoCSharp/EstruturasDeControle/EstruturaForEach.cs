using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaForEach
    {
        public static void Executar()
        {
            var palavra = "OPA!";

            foreach( var letra in palavra)  //o foreach vai fazer a variavel letra percorrer na string palavra
            {
                Console.WriteLine(letra);
            }
            var alunos = new string[] { "Ana", "Bia", "Carlos" };

            foreach(string aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
                
        }
    }
}
