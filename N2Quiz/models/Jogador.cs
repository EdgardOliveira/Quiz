using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2Quiz
{
    class Jogador
    {
        public string Nome { get; set; }
        public int NumeroQuestoes { get; set; }
        public double Pontuacao { get; set; }

        public Jogador()
        {

        }

        public Jogador(string nome, int numeroQuestoes, double pontuacao)
        {
            this.Nome = nome;
            this.NumeroQuestoes = numeroQuestoes;
            this.Pontuacao = pontuacao;
        }
    }
}
