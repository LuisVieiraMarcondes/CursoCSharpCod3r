using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{

    public class CalculadoraEstatica
    {   

        public static int Multiplicar(int a, int b) // Método de Classe , um método estático!!!!
        {
            return a + b;

        }
        public int Somar(int a, int b) // Método de Instancia; criando um objeto!
        {
            return a * b;
        }
    }

    class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("REsultado: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2, 2));
        }
    }
}
