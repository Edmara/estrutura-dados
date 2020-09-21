using System;
namespace vetor
{
    public class Aluno
    {
        private string nome;
        public Aluno(string nome) => this.nome = nome;

        public string getNome(){
            return this.nome;
        }

        public override bool Equals(object obj)
        {
            return obj is Aluno aluno &&
                   nome == aluno.nome;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}