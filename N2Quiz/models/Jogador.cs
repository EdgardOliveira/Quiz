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
        public int Acertos { get; set; }
        public int Erros { get; set; }
        public double PercAcertos { get; set; }
        public  double PercErros { get; set; }

        public Jogador()
        {

        }

        public Jogador(string nome, int acertos, double percAcertos, int erros, double percErros)
        {
            this.Nome = nome;
            this.Acertos = acertos;
            this.PercAcertos = percAcertos;
            this.Erros = erros;
            this.PercErros = percErros;
        }
    }
}
