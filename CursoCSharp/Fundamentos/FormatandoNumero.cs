using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            //"F1" siginifica a função de quantos algarismo depois da vírgula;
            Console.WriteLine(valor.ToString("C"));
            //"C" significa Currency, ou valor de moeda!;
            Console.WriteLine(valor.ToString("P"));
            //"P" cria um valor porcentual encima da String;
            Console.WriteLine(valor.ToString("#.##"));
            //"#.##" siginifica a função de quantos algarismo depois da vírgula;

            CultureInfo cultura = new CultureInfo("cz-CZ");
            //usa os valores de moedas e medidas do país selecionado;

            Console.WriteLine(valor.ToString("C3", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));


        }
    }
}
