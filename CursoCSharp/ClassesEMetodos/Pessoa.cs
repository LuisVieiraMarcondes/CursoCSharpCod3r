using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa                    //

    { 
        public string Nome;     //Atributo da classe Pessoa
        public int Idade;       //Atributo da classe Pessoa
    
        public string Apresentar() //método do comportamento da classe Pessoa que vai retornar uma "string"
        {
            return string.Format($"Olá! Me chamo {Nome} e tenho {Idade} anos."); //retorna uma string formatada com o comando "Format"
        }

        public void ApresentarNoConsole()   //o método void não retorna nada 
        {
            Console.WriteLine(Apresentar());//chamando o resultado string do método apresentar. colocando no Console
        }


    }

}       


