using System;

namespace N2Quiz
{
    class Pergunta
    {
        public int Numero { get; set; }
        public string Questao { get; set; }
        public string AlternativaA { get; set; }
        public string AlternativaB { get; set; }
        public string AlternativaC { get; set; }
        public string AlternativaD { get; set; }
        public string Resposta { get; set; }
        public int Tempo { get; set; }

        /// <summary>
        /// Construtor vazio - Possibilita instanciar a classe sem a necessidade 
        /// de passar parâmetros
        /// </summary>
        public Pergunta()
        {

        }

        /// <summary>
        /// Construtor com parâmetros - Instancia a classe e já configura as propriedades
        /// </summary>
        /// <param name="numero">Número da questão</param>
        /// <param name="questao">Pergunta a ser exibida</param>
        /// <param name="alternativaA">Resposta da Alternativa A</param>
        /// <param name="alternativaB">Resposta da Alternativa B</param>
        /// <param name="alternativaC">Resposta da Alternativa C</param>
        /// <param name="alternativaD">Resposta da Alternativa D</param>
        /// <param name="resposta">Resposta correta</param>
        /// <param name="tempo">Tempo configurado para a pergunta</param>
        public Pergunta(int numero, string questao, string alternativaA, string alternativaB, string alternativaC, string alternativaD, string resposta, int tempo)
        {
            Numero = numero;
            Questao = questao ?? throw new ArgumentNullException(nameof(questao));
            AlternativaA = alternativaA ?? throw new ArgumentNullException(nameof(alternativaA));
            AlternativaB = alternativaB ?? throw new ArgumentNullException(nameof(alternativaB));
            AlternativaC = alternativaC ?? throw new ArgumentNullException(nameof(alternativaC));
            AlternativaD = alternativaD ?? throw new ArgumentNullException(nameof(alternativaD));
            Resposta = resposta;
            Tempo = tempo;
        }

        /// <summary>
        /// Método responsável por validar e verificar se a resposta está correta
        /// </summary>
        /// <param name="tempo">Tempo em que o usuário clicou</param>
        /// <param name="resposta">Resposta selecionada pelo usuário</param>
        /// <returns>true   se estiver dentro do tempo e a resposta for a correta
        ///          false  se o tempo expirou ou a resposta estiver incorreta 
        /// </returns>
        public bool VerificarResposta(int tempo, string LetraResposta)
        {
            bool status = false;

            this.Tempo = tempo;

            if ((tempo>0) && (LetraResposta.Equals(this.Resposta.ToUpper())))
                status = true;

            Console.WriteLine("Tempo: " + tempo +
                  "\nResposta: " + this.Resposta.ToUpper() +
                  "\nLetra Selecionada: " + LetraResposta +
                  "\nStatus: " + status);

            return status;
        }
    }
}
