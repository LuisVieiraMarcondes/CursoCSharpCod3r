using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{

    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);


            var carrinho = new HashSet<Produto>();      //Estrutura HashSet não é INDEXADA, qualquer ação de indice será removida!

            carrinho.Add(livro);


            var combo = new HashSet<Produto>
            {
                new Produto("camiseta", 29.9),
                new Produto("8a temporada Game of Thrones", 99.9),
                new Produto("Poster", 10)
            };

            carrinho.UnionWith(combo);           //Como o Set é um conjunto, vamos usar o comando de União de conjuntos...UNIONWITH!

            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3);              

            foreach (var item in carrinho)
            {
                // Console.Write(carrinho.IndexOf(item));         
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);  //O Set não aceita repetição de ITEM!
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);


        }
    }
}
