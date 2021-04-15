using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    class LINQ2
    {
        public static void Executar()
        {
            var alunos = new List<Aluno> {  // a mesma lista do linq1
                new Aluno() {Nome = "Pedro", Idade = 24, Nota = 8.0 },
                new Aluno() {Nome = "Andre", Idade = 21, Nota = 4.3 },
                new Aluno() {Nome = "Ana", Idade = 25, Nota = 9.5 },
                new Aluno() {Nome = "Jorge", Idade = 20, Nota = 8.5 },
                new Aluno() {Nome = "Ana", Idade = 21, Nota = 7.7 },
                new Aluno() {Nome = "Julia", Idade = 22, Nota = 7.5 },
                new Aluno() {Nome = "Marcio", Idade = 18, Nota = 6.8 }
            };

            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome} {pedro.Nota}");

            var fulano = alunos.SingleOrDefault(        
                aluno => aluno.Nome.Equals("Fulano"));
            if (fulano == null)     //não esquecer que o valor padrão de um objeto é NULL!
            {
                Console.WriteLine("Aluno Inexistente!");
            }

            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));  //vamos procurar o primeiro igual a Ana!
            Console.WriteLine(ana.Nota);
                
            var sicrano = alunos.FirstOrDefault(    //senão querer exceções use o FirstOrDefault
                aluno => aluno.Nota.Equals("Sicrano"));
            if (sicrano == null)    //e criamos a condicional
            {
                Console.WriteLine("Aluno Inexistente!");
            }

            var outraAna = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Ana")); //procurar o ultimo 
            Console.WriteLine(outraAna.Nota);

            var exemploSkip = alunos.Skip(1).Take(3);   //o exemplo skip vai pular 1 que é o primeiro e pegar os 3 próximos.
            foreach (var item in exemploSkip)
            {
                Console.WriteLine(item.Nome);
            }

            var maiorNota = alunos.Max(aluno => aluno.Nota);    //pega o máximo do atributo nota do aluno
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota);    //pega a menor nota
            Console.WriteLine(menorNota);

            var somatorioNotas = alunos.Sum(aluno => aluno.Nota);   //soma todas as notas
            Console.WriteLine(somatorioNotas);

            var mediaDaTurma = alunos.Average(aluno => aluno.Nota);     //cria a média das notas!
            var mediaDeAprovados = alunos.Where(a => a.Nota >= 7).Average(aluno => aluno.Nota);     //cria a média das notas somente dos aprovados!
            Console.WriteLine("média Total: " + mediaDaTurma);
            Console.WriteLine("média dos Aprovados: " + mediaDeAprovados);
        }
    }
}
