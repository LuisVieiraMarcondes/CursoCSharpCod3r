using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Cliente
    {
        //atributo publico
        public string Nome;
        readonly DateTime Nascimento; //readonly é um valor imutável e avaliado no contexto de execução do seu programa
        //const int x = 100;                                //e uma constante necessita ser inicializada no seu programa

        //Construtor
        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }
        public string GetDataNascimento()
        {
            return String.Format("{0}/{1}/{2}", Nascimento.Day,
                Nascimento.Month, Nascimento.Year);

        }
    }

    class ReadOnly

    {
        public static void Executar()
        //public - transforma a funçao visivel pra que outro namespace consiga acessa-la

        //static - não preciso criar um objeto

        //void - não necessita retornar nada

        {
            var novoCliente = new Cliente("Ana Silva", new DateTime(1987, 5, 22));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataNascimento());

            
        }
    }
}







