using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    class LINQ2
    {
        public static void Executar()
        {
            var alunos = new List<Aluno> {
                new Aluno() {Nome = "Pedro", Idade = 24, Nota = 8.0 },
                new Aluno() {Nome = "Andre", Idade = 21, Nota = 4.3 },
                new Aluno() {Nome = "Ana", Idade = 25, Nota = 9.5 },
                new Aluno() {Nome = "Jorge", Idade = 20, Nota = 8.5 },
                new Aluno() {Nome = "Ana", Idade = 21, Nota = 7.7 },
                new Aluno() {Nome = "Julia", Idade = 22, Nota = 7.5 },
                new Aluno() {Nome = "Marcio", Idade = 18, Nota = 6.8 }
            };

            //função Single retorna apenas um resultado
            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome} {pedro.Nota}");

            //função SingleOrDefault retorna o resultado no Equals esperado, ou Null por padrao
            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano"));
            if (fulano == null)
            {
                Console.WriteLine("Aluno Inexistente!");
            }

            //Firs retorna o primeiro que encontrar do criterio passado
            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(ana.Nota);

            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nota.Equals("Sicrano"));
            if (sicrano == null)
            {
                Console.WriteLine("Aluno Inexistente!");
            }

            var outraAna = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(outraAna.Nota);

            //Skip pula e Take pega uma sequencia, no caso abaixo pula 1 pega 3, pula 1 pega 3 ...
            var exemploSkip = alunos.Skip(1).Take(3);
            foreach (var item in exemploSkip)
            {
                Console.WriteLine(item.Nome);
            }
            //Max pega o maior
            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);
            //Min pega o menor
            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);
            //Sum pega a soma das notas
            var somatorioNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somatorioNotas);
            //Average retorna a media, no caso abaixo retorna a media dos alunos com nota >=7
            var mediaDaTurma = alunos.Where(a => a.Nota >= 7).Average(aluno => aluno.Nota);
            Console.WriteLine(mediaDaTurma);
        }
    }
}
