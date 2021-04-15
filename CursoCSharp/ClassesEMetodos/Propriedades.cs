using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        double desconto = 0.1;

        string nome;

        public string Nome
        {
            get
            {
                return "Opcional: " + nome;

            }
            set
            {
                nome = value;

            }
        }
        //Propriedades autoimplementada
        public double Preco { get; set; }


        //Somente Leitura
        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco); //Lambda

        }
        //Método Construtor Padrão
        public CarroOpcional()
        {

        }
        public CarroOpcional(string nome, double preco)
        {   //1a opção usando o this setando o valor interno
            //this.nome = nome;
            //2a opção setei as propriedades "Nome" e "Preco" , com os parametros "nome" e "preco";
            Nome = nome;
            Preco = preco;

        }



    }
    class Propriedades
    {
        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar Condicional", 3499.99);
            Console.WriteLine(op1.PrecoComDesconto);

            var op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 2349.9;

            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);

            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconto);





        }
    }

}
