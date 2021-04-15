using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia };    //prefiram colocar sem acento as raferencias de Enum 

    public class Filme
    {   //criamos dois atributos do Filme
        public string Titulo;
        public Genero GeneroDoFilme;

    }
    class ExemploEnum
    {
        public static void Executar()
        {
            int id = (int)Genero.Animacao;      //(int) é o comando de conversão que será usado na string Genero Enum
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Sharknado 17";
            filmeParaFamilia.GeneroDoFilme = Genero.Comedia; //usando o nome do Enum

            Console.WriteLine("{0} é {1}!", filmeParaFamilia.Titulo, filmeParaFamilia.GeneroDoFilme);

        }
    }
}
