using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados
{
    class Dynamics
    {
        public static void Executar()
        {
            dynamic meuObjeto = "teste";    //criamos uma variavel dynamics para string, com caracteristica de fracamente tipada!
            meuObjeto = 3;  //se tipamos o meu objeto pra int ele vai incrementar e imprimir, mas se comentamos essa linha vai causar exceção!

            meuObjeto++;    //operador unário de incremento o meuobjeto vai pra 4!
            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject(); //vamos criar um objeto que vamos acrescentar chaves dinamicas! não usamos essa forma como padrão!
            aluno.nome = "Maria Julia";
            aluno.nota = 8.9;
            aluno.idade = 24;

            Console.WriteLine($"{aluno.nome} {aluno.nota} {aluno.idade}"); 
        }
    }
}
