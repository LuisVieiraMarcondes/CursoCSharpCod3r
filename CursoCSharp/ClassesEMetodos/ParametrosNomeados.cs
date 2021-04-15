using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano)
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano); //{0:D2} se o numero tiver um digito ele irá inserir um zero antes

        }

        public static void Executar()
        {
            Formatar(mes: 1, dia: 6, ano: 1996);

        }       //é melhor ter um codigo mais escrito mais claro do que um codigo curto e ilegivel.
                
    }
}
