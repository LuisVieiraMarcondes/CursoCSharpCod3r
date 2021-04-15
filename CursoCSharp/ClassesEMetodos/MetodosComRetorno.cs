using CursoCSharp.ClassesEMetodos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraComum  //automaticamente existe um contrutor padrao nessa classe
    {
        public int Somar(int a, int b)          //metodo que vai retornar tipo int com o parametro receber um int a e int b
        {
            return a + b;   //assinatura do método, retorna o que foi colocado que o método tinha que retornar (nesse caso foi a variavel int)

        }
        public int Subtrair(int a, int b)
        {

            return a - b;
        }
        public int Multiplicar(int a, int b)
        {

            return a * b;
        }
    }
        class CalculadoraCadeia     //encadeiamos várias chamadas numa unica sentença de código que a Funçao retorna o proprio objeto
        {
            int memoria; // ele está sempre armazenando o valor na int memoria da calculadora...

            public CalculadoraCadeia Somar(int a)   //Funcao Somar
            {
                memoria += a;           //This quer dizer a instancia atual que vc está trabalhando
                return this;            //retorno no proprio objeto
            }
            public CalculadoraCadeia Multiplicar(int a)
            {
                memoria *= a;
                return this;
            }
            public CalculadoraCadeia Limpar()
            {
                memoria = 0;
                return this;
            }
            public CalculadoraCadeia Imprimir()
            {
                Console.WriteLine(memoria);
                return this;
            }
            public int Resultado()
            {
                return memoria;
            }
        }
    

    class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadorComum = new CalculadoraComum();
            var resultado = calculadorComum.Somar(5, 5);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadorComum.Subtrair(2, 7));
            Console.WriteLine(calculadorComum.Multiplicar(4, 4));

        var calculadoraCadeira = new CalculadoraCadeia();
        calculadoraCadeira.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();

        resultado = calculadoraCadeira.Somar(3).Multiplicar(2).Resultado();
        Console.WriteLine(resultado);



        }
    }
}
