using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Produto
    {
        public string Nome;                 //atributos marcados sem static, todos esses atributos são especificos para cada objeto.
        public double Preco;
        public static double Desconto = 0.1;    //O atributo static pertence a classe agora

        public Produto(string nome, double preco, double desconto)  //construtor com os tres parametros
        {
            Nome = nome;          //como existe minusculo para os paramentros e maiusculo para os atributos, não necessita do comando this.
            Preco = preco;
            Desconto = desconto;
        }
        public Produto()        //Construtor Padrao
        {

        }
        public double CalcularDesconto()    //Criamos o método CalcularDesconto
        {
            return Preco - Preco * Desconto;

        }

    }
    class AtributosEstaticos
    {
        public static void Executar()
        {
            var produto1 = new Produto("Caneta", 3.2, 0.1);

            var produto2 = new Produto()
            {
                Nome = "Borracha",      //como o atributo estatico na classe, não consigo acessar mais o atributo na instancia
                Preco = 5.3,                
            };

            Produto.Desconto = 0.5;     //acesso diretamente da classe do Atributo Desconto...,o atributo desconto pertence a classe e não mais as instancias.

            Console.WriteLine("Preço com Desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com Desconto: {0}", produto2.CalcularDesconto());

            Produto.Desconto = 0.02;        

            Console.WriteLine("Preço com Desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com Desconto: {0}", produto2.CalcularDesconto());

        }
    }
}
