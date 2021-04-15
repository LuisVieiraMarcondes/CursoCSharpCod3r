using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];    //Array é uma coleção homogênea, vc vai poder colocar só valores homogêneos...e o array é uma estrutura estatica,
            alunos[0] = "Anderson";                                    //Array é uma estrutura indexada, que seria acessada por indices!...ex: aluno[0] = "Anderson"
            alunos[1] = "Bia";
            alunos[2] = "Carlos";
            alunos[3] = "Daniela";
            alunos[4] = "Emanuel";                                   //foreach é uma excelente opção de trabalhar com as arrays

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach (var nota in notas) //consigo trabalhar com a array sem criar controle com muitas variaveis 
            {
                somatorio += nota;
            }

            //for(int i = 0; i < notas.lenght; i++)
            //{
            //    somatorio += notas[i];
            //}

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);


        }
    }
}
