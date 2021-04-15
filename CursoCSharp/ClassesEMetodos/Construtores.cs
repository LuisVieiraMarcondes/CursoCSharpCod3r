using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro //3 atributos e 2 construtores
    {
        public string Modelo;       //3 atributos da classe Maiusculo
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano)     //atributos do construtor são minusculo
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;

        }

        public Carro() //construtor padrao que não recebe nenhum paramentro
        {

        }

    }
    class Construtores
    {
        public static void Executar()
        {
            var carro1 = new Carro(); //Construtor padrão é o método que não recebe nenhum parametros e retorna uma instancia do tipo do qual usou.
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;
            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            var carro2 = new Carro("Ka", "Ford", 2018);
            Console.WriteLine($"{carro2.Modelo} {carro2.Fabricante} {carro2.Ano}");

            var carro3 = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2019

            };
            Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");

        }
    }
}
