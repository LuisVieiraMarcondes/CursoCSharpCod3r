using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Api
{
    class ExemploTimeSpan   //é um estrutura que mostra um intervalo de tempo!
    {
        public static void Executar()
        {
            var intervalo = new TimeSpan(days: 10, hours: 20, minutes: 30,  
                seconds: 40);   //colocamos os valores literais para mostrar a sequencia do tempo entre dias e segundos!
            Console.WriteLine(intervalo);

            Console.WriteLine("Minutos: " + intervalo.Minutes);
            Console.WriteLine("Intervalo em Minutos: "
                + intervalo.TotalMinutes);

            var largada = DateTime.Now;
            var chegada = DateTime.Now.AddMinutes(15);  //colocamos a diferença da largada e chegada em 15 min!

            var tempo = chegada - largada;

            Console.WriteLine("Duração: " + tempo);

            Console.WriteLine(intervalo.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine(intervalo.Subtract(TimeSpan.FromMinutes(8)));

            Console.WriteLine("ToString 1: " + intervalo.ToString("g"));
            Console.WriteLine("ToString 2: " + intervalo.ToString("G"));
            Console.WriteLine("ToString 3: " + intervalo.ToString("c"));

            Console.WriteLine("Parse: " +
                TimeSpan.Parse("01:02:03").TotalMilliseconds);
        }
    }
}
