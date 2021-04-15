using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Api
{
    class ExemploDateTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(year: 2030, month: 2, day: 6);      //criando um DateTime!

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            // Sem horas
            var hoje = DateTime.Today;  //usando o today só coloca a data sem a hora!
            Console.WriteLine(hoje);

            // Com horas
            var diaAtual = DateTime.Now;    
            Console.WriteLine(diaAtual);
            Console.WriteLine("Hora: " + diaAtual.Hour);
            Console.WriteLine("Minutes: " + diaAtual.Minute);

            var amanha = diaAtual.AddDays(1);   //adiciona um dia da data atual
            Console.WriteLine(amanha);

            var ontem = diaAtual.AddDays(-1); //subtrai um dia da data atual
            Console.WriteLine(ontem);

            Console.WriteLine(diaAtual.ToString("dd")); //mostra o dia atual
            Console.WriteLine(diaAtual.ToString("d"));  //mostra o dia atual como data de mes ano incluso
            Console.WriteLine(diaAtual.ToString("D"));  //mostra o dia no modo mais descritivo
            Console.WriteLine(diaAtual.ToString("g"));  //mostra dia atual com a hora
            Console.WriteLine(diaAtual.ToString("G"));  //mostra o dia atual com a hora mostrando  os segundos
            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:mm"));   //mostra a data com hora de forma mais descritiva
        }
    }
}
