using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 10;


        public static void Executar()
        { // Acessar a variavel a dentro do método estatico Executar!
            //tenho que criar uma instancia desafio e usar comando "anotação ponto" com a instancia para acessar a variavel int a;
            DesafioAtributo desafio = new DesafioAtributo();
            
                Console.WriteLine(desafio.a);   
            
        }
    }
}
