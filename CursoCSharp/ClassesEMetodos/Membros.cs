using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{                   //As classes Membros e Pessoa estão no mesmo namespace, poderiam estar instanciadas por exemplo no mesmo programa dentro da

    class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();      //tipo da variavel é Pessoa, o nome da variavel é sicrano, recebe new e Pessoa é um construtor para criar uma nova pessoa;
            sicrano.Nome = "Renato";            //e o novo objeto recebe os seus atributos.
            sicrano.Idade = 21;

            // Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");

            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa(); //criando um novo objeto do tipo fulano
            fulano.Nome = "Beto";       //atributos do novo objeto
            fulano.Idade = 21;

            var apresentacaoDoFulano = fulano.Apresentar();     //ctrl + click do mouse você navega pela função;
            Console.WriteLine(apresentacaoDoFulano.Length);
            Console.WriteLine(apresentacaoDoFulano);
        }
    }
}
