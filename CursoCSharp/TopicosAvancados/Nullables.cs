using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados
{
    class Nullables
    {
        public static void Executar()
        {
            Nullable<int> num1 = null;  //criamos um nullable com notação generics
            int? num2 = null;   //criando um nullable com int com interrogação?
            //int num3 = null;    //gera erro, porque não é possível converte um nulo para um int!


            if (num1.HasValue)  
            {
                Console.WriteLine("Valor de num: {0}", num1);
            }
            else
            {
                Console.WriteLine("A variável não possui valor.");  //criando a condicional vamos escrever no console que num1 é null!
            }

            int valor = num1 ?? 1000;   //operador de coalescência:  as 2 interrogação, o num1 estiver nulo e vai aceitar o valor padrão (1000)!
            Console.WriteLine(valor);

            /*O ideal é não trbalhar com valores nulos
             * mas se precisar é necessário suar tratamentos de exceções!
             */
            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();
            Console.WriteLine(resultado);

            try
            {
                int x = num1.GetValueOrDefault();
                int y = num2.GetValueOrDefault();
                Console.WriteLine(x + y);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
