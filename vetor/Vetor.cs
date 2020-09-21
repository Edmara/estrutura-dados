using System;

namespace vetor
{
    public class Vetor
    {
        public Aluno[] alunos = new Aluno[100];
        private int totalDeAlunos = 0;

        public void Adiciona(Aluno aluno)
        {
            this.alunos[totalDeAlunos] = aluno;
            totalDeAlunos++;
        }

        public void RedimencionaArray()
        {
            if (totalDeAlunos == alunos.Length)
            {
                Aluno[] novoArray = new Aluno[alunos.Length * 2];
                for(var i = 0; i < alunos.Length; i++){
                    novoArray[i] = alunos[i];
                }
                this.alunos = novoArray;
            }
        }

        public void Adiciona(int posicao, Aluno aluno)
        {
            if (!PosicaoValida(posicao))
            {
                throw new ArgumentException("posicao invalida");
            }
            for (var i = totalDeAlunos - 1; i >= posicao; i -= 1)
            {
                alunos[i + 1] = alunos[i];
            }

            alunos[posicao] = aluno;
            totalDeAlunos++;
        }

        public int Tamanho()
        {
            return totalDeAlunos;
        }

        private bool PosicaoOcupada(int posicao)
        {
            return posicao >= 0 && posicao < totalDeAlunos;
        }

        private bool PosicaoValida(int posicao)
        {
            return posicao >= 0 && posicao <= totalDeAlunos;
        }

        public Aluno Pega(int posicao)
        {
            if (!PosicaoOcupada(posicao))
            {
                throw new ArgumentException("Posição inválida");
            }
            return alunos[posicao];
        }

        public void Remove(int posicao)
        {
            for (var i = posicao; i < totalDeAlunos; i++)
            {
                this.alunos[i] = this.alunos[i + 1];
            }
            totalDeAlunos--;
        }

        public bool Contem(Aluno aluno)
        {
            for (int i = 0; i < totalDeAlunos; i++)
            {
                if (aluno.Equals(alunos[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public void PrintValues()
        {
            foreach (Aluno aluno in alunos)
            {
                if (aluno != null)
                    Console.Write("\t{0}", aluno.getNome());
            }
            Console.WriteLine();
        }

    }

}
