using System;
using CursoCSharp.ClassesEMetodos;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados
{
    public class Caixa<T>   //Criamos a classe Caixa, e nessa caixa temos anotação de genérico! que o valor T é valor aberto!
    {
        T valorPrivado; //definimos a variavel T como atributo
        public T Coisa { get; set; }    //criamos uma propriedade T com get e set;

        public Caixa(T coisa)   //criamos um parametro T em um construtor
        {
            Coisa = coisa;
            valorPrivado = coisa;
        }

        public T metodoGenerico(T valor)    //método genérico com parametro T.
        {
            return new Random().Next(0, 2) == 0 ? Coisa : valor;
        }

        public T GetValor() //método que retorna o tipo T
        {
            return valorPrivado;
        }
    }

    class CaixaInt : Caixa<int> //Criamos uma class Caixaint que herda de Caixa
    {
        public CaixaInt() : base(0) //contrutor Caixaint herdando base 
        {

        }
    }

    class CaixaProduto : Caixa<Produto>
    {
        public CaixaProduto() : base(new Produto())
        {

        }
    }

    class Genericos
    {
        public static void Executar()
        {
            var caixa1 = new Caixa<int>(1000);  //instanciamos caixa1 int de parametro inicial(1000)
            Console.WriteLine(caixa1.metodoGenerico(33));
            Console.WriteLine(caixa1.Coisa.GetType());  //aqui imprimi o tipo do caixa1

            var caixa2 = new Caixa<string>("Construtor");
            Console.WriteLine(caixa2.metodoGenerico("Método"));
            Console.WriteLine(caixa2.Coisa.GetType());

            CaixaProduto caixa3 = new CaixaProduto();   //instaciamos um CaixaProduto
            Console.WriteLine(caixa3.Coisa.GetType().Name); //teremo o Produto como nome!

            /*Existem duas formas de declarar generics,  como instanciar, e como na herança!
             */
        } 
    }
}
