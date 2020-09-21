using System;

namespace vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno primeiroAluno = new Aluno("João");
            Aluno segundoAluno = new Aluno("Jose");

            Vetor lista = new Vetor();

            lista.Adiciona(primeiroAluno);
            lista.Adiciona(segundoAluno);

            lista.PrintValues();

            Aluno terceiroAluno = new Aluno("Danilo");
            Console.WriteLine(lista.Contem(primeiroAluno));
            Console.WriteLine(lista.Contem(terceiroAluno));


                lista.Adiciona(1, terceiroAluno);
               lista.PrintValues();


        }

    }
}
