using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

    }
    class ColecoesList
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);


            var carrinho = new List<Produto>();
            //comando List vai usar o system collection.generics
            carrinho.Add(livro);                                                //Dentro de uma coleção não é interessante que você misture os dados.


            var combo = new List<Produto>
            {
                new Produto("camiseta", 29.9),
                new Produto("8a temporada Game of Thrones", 99.9),
                new Produto("Poster", 10)
            };

            carrinho.AddRange(combo);           //Todos os elmentos adicionados no Combo, irão ser adicionados no carrinho...
                                                //"AddRange" é um comando para adicionar o conteúdo de uma lista dentro de outra!
            Console.WriteLine(carrinho.Count);  //Comando "Count" vai contar quantos elementos tenho dentro do atributo carrinho.
            carrinho.RemoveAt(3);               //RemoveAt (3), é o comando de remover o elemento de indice 3.

            foreach (var item in carrinho)
            {
                Console.Write(carrinho.IndexOf(item));          //
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);                //vai ser acrescentado novamente, porque a List pode adicionar dois elemntos iguais dentro de uma lista;
            Console.WriteLine(carrinho.Count);

            //A List é uma estrutura Dinamica(cresce dinamicamente apartir que eu adiciono elementos), aceita repetições e , é Indexada!
        }
    }
}
