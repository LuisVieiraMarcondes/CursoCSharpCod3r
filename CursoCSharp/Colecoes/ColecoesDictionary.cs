using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesDictionary
    {           //Dicionário é uma strutura de CHAVE e VALOR, que agrega um SET (não aceita repetição na chave) e um list (aceita repetição no valor)
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>(); //Adicionamos um Dicionario é uma estrutura CHAVE VALOR , e usando os valores int e string;

            filmes.Add(2000, "Gladiador");  //adicionamos objetos no dicionario com comando ADD
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004))
            {
                Console.WriteLine("2004: " + filmes[2004]);
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004)); //usando GetValueorDEfault não precisaremos do colchete!
            }

            Console.WriteLine(filmes.ContainsValue("Amnésia"));
            Console.WriteLine($"REmoveu? {filmes.Remove(2004)}");


            filmes.TryGetValue(2006, out string filme2006);
            Console.WriteLine($"Filme {filme2006}!");

            foreach (var chave in filmes.Keys)   //Percorrendo as CHAVES(Keys) com o FOREACH!
            {
                Console.WriteLine(chave); //Não irá mostrar o filme 2004 porque removemos essa chave!!!
            }

            foreach (var valor in filmes.Values)    //Percorrendo os VALORES(Values) com o FOREACH!
            {
                Console.WriteLine(valor);
            }

            foreach (KeyValuePair<int, string> filme in filmes)  //Percorrendo as CHAVES E VALORES com o FOREACH! Usamos o comando (KeyValuePair)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }

            foreach (var filme in filmes)    //Percorrendo as Chaves e Valores usando uma VAR em FOREACH!
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }
        }
    }
}
