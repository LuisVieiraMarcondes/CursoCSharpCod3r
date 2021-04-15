using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{           //uma interface tem sintaxe parecidas com as classes, mas se voce criar funcoes que tenham um corpo, voce criar apenas assinatura da funcao, e quem tiver aderente a 
            //essa interface ,signifca que a strutura com a mesma assinatura e tipo de retorno.
    interface Ponto
    {   //criamos uma funcao sem corpo
        void MoverNaDiagonal(int delta);            //nao podemos colocar um private para um método de uma interface, automaticamente ele será publico.

    }

    struct Coordenada : Ponto   //struct coordenada precisa ser aderente a interface Ponto
    {   //atributos
        public int X;
        public int Y;

        //construtor
        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void MoverNaDiagonal(int delta)
        {
            X += delta;
            Y += delta;
        }

    }
    class ExemploStruct
    {
        public static void Executar()
        {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            Console.WriteLine("Coordenada Inicial:");
            Console.WriteLine("X = {0}", coordenadaInicial.X);
            Console.WriteLine("Y = {0}", coordenadaInicial.Y);

            var coordenadaFinal = new Coordenada(x: 9, y: 1);
            coordenadaFinal.MoverNaDiagonal(10);

            Console.WriteLine("Coordenada Final:");
            Console.WriteLine("X = {0} ", coordenadaFinal.X);
            Console.WriteLine("Y = {0} ", coordenadaFinal.Y);


        }
    }
}
