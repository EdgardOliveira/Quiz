using N2Quiz.controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace N2Quiz
{
    partial class FrmQuiz : Form
    {
        //atributos
        private Jogador jogador { get; set; }
        private Pergunta pergunta { get; set; }
        private string AlternativaSelecionada { get; set; }
        private static List<Pergunta> ListaPerguntas { get; set; }
        
        private bool TempoExpirado;
        
        private bool Respondeu;

        public bool Proxima { get; private set; }

        const int TEMPO = 11;


        /// <summary>
        /// Construtor com parâmetros da classe
        /// </summary>
        /// <param name="jogador">Recebe um jogador</param>
        public FrmQuiz(Jogador jogador)
        {
            InitializeComponent();
            //atribuindo os dados do jogador enviados da outra tela
            this.jogador = jogador;

            //inicializando a lista de perguntas
            ListaPerguntas = new List<Pergunta>();

            //configurando os dados arquivo de perguntas
            Importar ImportarArquivo = new Importar(Application.StartupPath, Globais.ARQ_PERGUNTAS);

            //importando os dados do arquivo para tabela
            DataTable dataTable = ImportarArquivo.CarregarDados();
            
            //Convertendo a tabela em lista
            ImportarArquivo.ConvertDataTableToList(dataTable);
            
            //atribuinda os dados da lista
            ListaPerguntas = ImportarArquivo.ListaPerguntas;
                        
            //carregando dados da primeira pergunta
            pergunta = ListaPerguntas[0];
            pergunta.Tempo = TEMPO;
        }

        /// <summary>
        /// Método responsável por fazer a verificação da resposta do usuário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerificarResposta_Click(object sender, EventArgs e)
        {
            DateTime dt = Convert.ToDateTime("00:00:" + lblTempo.Text);
            int segundos = dt.Second;

            if (pergunta.VerificarResposta(segundos, AlternativaSelecionada))
            {
                //resposta correta... exibe imagem
                pnlResultado.BackgroundImage = Properties.Resources.acertomizeravi;
                Application.DoEvents();

                //incrementa a quantidade de questoes que o jogador acertou
                jogador.Acertos++;

                //incrementa a pontuação do jogador (%)
                jogador.PercAcertos = CalcularPercentual(jogador.Acertos, pergunta.Numero);
                jogador.PercErros = CalcularPercentual(jogador.Erros, pergunta.Numero);

                ValidarProximaSalvar();
            }
            else
            {
                //resposta incorreta... exibe a imagem
                pnlResultado.BackgroundImage = Properties.Resources.errou;
                Application.DoEvents();

                //incrementa o erro
                jogador.Erros++;
                jogador.PercErros = CalcularPercentual(jogador.Erros, pergunta.Numero);

                //incrimenta a pontuação do jogador (%)
                if (jogador.Acertos > 0)
                {
                    jogador.PercAcertos = CalcularPercentual(jogador.Acertos, pergunta.Numero);
                    jogador.PercErros = CalcularPercentual(jogador.Erros, pergunta.Numero);
                }
                else
                    jogador.PercAcertos = 0;

                ValidarProximaSalvar();
            }                
        }

        /// <summary>
        /// Método responsável por fazer o cálculo percentual
        /// </summary>
        /// <param name="X">a parte a ser calculada</param>
        /// <param name="Total">O correspondente a 100% do valor</param>
        /// <returns></returns>
        private double CalcularPercentual(double X, double Total)
        {
            return (X * 100) / Total;
        }

        private int ConfigurarExibicaoTempo()
        {
            //se houver tempo
            if (pergunta.Tempo > 0)
            {
                //decrementa o tempo
                pergunta.Tempo--;

                //atualiza o label que exibe o tempo formatando com 2 dígitos
                lblTempo.Text = pergunta.Tempo.ToString().PadLeft(2, '0');
                switch (pergunta.Tempo)
                {
                    case 10:
                    case 9:
                    case 8:
                    case 7:
                    case 6:
                        //se a cor da label for azul ou preta
                        if ((lblTempo.ForeColor == Color.RoyalBlue) || (lblTempo.ForeColor == Color.Black))
                            lblTempo.ForeColor = Color.Yellow;  //muda para amarelo
                        else if (lblTempo.ForeColor == Color.Yellow) //senão... se for amarela
                            lblTempo.ForeColor = Color.Black; //muda para preto
                        break;
                    case 5:
                    case 4:
                    case 3:
                    case 2:
                    case 1:
                        if ((lblTempo.ForeColor == Color.Yellow) || (lblTempo.ForeColor == Color.Black))
                            lblTempo.ForeColor = Color.Red; //muda para vermelho
                        else if (lblTempo.ForeColor == Color.Red) //se for vermelho
                            lblTempo.ForeColor = Color.Black; //muda para preto
                        break;
                    case 0:
                        lblTempo.ForeColor = Color.Red; //muda para vermelho
                        break;
                    default:
                        lblTempo.ForeColor = Color.RoyalBlue; //a cor da label é azul 
                        break;
                }
            }
            return pergunta.Tempo;
        }

        private bool VerificarSeTempoExpirou()
        {
            bool Status = false;

            if (pergunta.Tempo == 0)
                Status = true;

            Console.WriteLine("O tempo expirou? {0}. Tempo: {1}", Status, pergunta.Tempo);

            return Status;
        }

        private bool VerificarStatusResposta()
        {
            bool Status = false;
            if (!String.IsNullOrEmpty(AlternativaSelecionada))
                Status = true;

            Console.WriteLine("Houve resposta? {0}. Resposta: {1}", Status, AlternativaSelecionada);

            return Status;
        }

        private bool VerificarProxima()
        {
            bool Status = false;
            if (pergunta.Numero < ListaPerguntas.Count)
                Status = true;

            Console.WriteLine("A pergunta atual {0} é menor que a quantidade {1}? Resposta= {2}", pergunta.Numero, ListaPerguntas.Count, Status);

            return Status;
        }

        private void ValidarProximaSalvar()
        {
            if (Proxima)
            {
                Console.WriteLine("Chamando a próxima questão...");
                ChamarProximaQuestao();
            }
            else
            {
                //atualiza a tela
                AtualizarDadosTela();

                //salvar os dados no ranking
                SalvarResultado();
            }
        }

        private bool VerificarSeExpirouSemResposta()
        {
            bool Status = false;

            if (TempoExpirado && !Respondeu)
            {

                Status = true;  //Expirou e ele não respondeu

                Console.WriteLine("Expirou sem resposta...");

                //considerar resposta incorreta... exibe a imagem
                pnlResultado.BackgroundImage = Properties.Resources.erroufeioerrourude;
                Application.DoEvents();

                //incrementa a pontuação do jogador (%)
                jogador.PercAcertos = CalcularPercentual(jogador.Acertos, pergunta.Numero);
                jogador.PercErros = CalcularPercentual(jogador.Erros, pergunta.Numero);

                //atualiza a tela
                AtualizarDadosTela();

                Console.WriteLine("Pode chamar a próxima? {0}", Proxima);

                ValidarProximaSalvar();
            }

            return Status;
        }
               
        /// <summary>
        /// Método que verifica o tempo do usuário a cada segundo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrQuiz_Tick(object sender, EventArgs e)
        {
            pergunta.Tempo = ConfigurarExibicaoTempo();
            TempoExpirado = VerificarSeTempoExpirou();
            Respondeu = VerificarStatusResposta();
            Proxima = VerificarProxima();

            VerificarSeExpirouSemResposta();
        }

        /// <summary>
        /// Método responsável por carregar os dados da próxima pergunta
        /// </summary>
        private void ChamarProximaQuestao()
        {
            Console.WriteLine("Esperando 2segundos...");
            //aguarda 3 segundos para permitir a exibição da imagem
            Thread.Sleep(3000);     // 3segundos
            //Application.DoEvents();

            Console.WriteLine("Iniciando o carregamento da próxima questão...");

            //guardar número da pergunta atual
            int numeroPerguntaAtual = pergunta.Numero;
            Console.WriteLine("Pergunta Atual: {0}", numeroPerguntaAtual);

            //instancia uma nova pergunta
            pergunta = new Pergunta();

            //pega a pergunta da lista
            pergunta = ListaPerguntas[numeroPerguntaAtual];

            //define o tempo dessa pergunta
            pergunta.Tempo = TEMPO;

            Console.WriteLine("ChamarProximaQuestao({0}", numeroPerguntaAtual);
            Console.WriteLine(pergunta);

            //configura as seleções como nula
            selecionarAlternativa(0);
                
            //atualiza a tela
            AtualizarDadosTela();
        }

        /// <summary>
        /// Método responsável por salvar a pontuação do jogador e mostrar o ranking
        /// </summary>
        private void SalvarResultado()
        {
            Arquivo arquivo = new Arquivo();
            arquivo.SalvarRanking(jogador, Application.StartupPath, Globais.ARQ_RANKING);


            tmrQuiz.Stop();

            MessageBox.Show("Fim de jogo.", "FIM", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Dispose();
            FrmRanking tela = new FrmRanking();
            tela.Show();
        }

        /// <summary>
        /// Método responsável por configurar as cores nos botões de acordo com os parâmetros
        /// enviados
        /// </summary>
        /// <param name="corA">0 - Não selecionado, 1 - Selecionado</param>
        /// <param name="corB">0 - Não selecionado, 1 - Selecionado</param>
        /// <param name="corC">0 - Não selecionado, 1 - Selecionado</param>
        /// <param name="corD">0 - Não selecionado, 1 - Selecionado</param>
        private void configurarBotoes(int corA, int corB, int corC, int corD)
        {
            switch (corA)
            {
                case 1:
                    btnAlternativaA.BackColor = Color.Red;
                    break;
                case 0:
                    btnAlternativaA.BackColor = Color.RoyalBlue;
                    break;
                default:
                    Console.WriteLine("Indefinido");
                    break;
            }
            switch (corB)
            {
                case 1:
                    btnAlternativaB.BackColor = Color.Red;
                    break;
                case 0:
                    btnAlternativaB.BackColor = Color.RoyalBlue;
                    break;
                default:
                    Console.WriteLine("Indefinido");
                    break;
            }
            switch (corC)
            {
                case 1:
                    btnAlternativaC.BackColor = Color.Red;
                    break;
                case 0:
                    btnAlternativaC.BackColor = Color.RoyalBlue;
                    break;
                default:
                    Console.WriteLine("Indefinido");
                    break;
            }
            switch (corD)
            {
                case 1:
                    btnAlternativaD.BackColor = Color.Red;
                    break;
                case 0:
                    btnAlternativaD.BackColor = Color.RoyalBlue;
                    break;
                default:
                    Console.WriteLine("Indefinido");
                    break;
            }
        }

        /// <summary>
        /// Método responsável por verificar a alternativa selecionada pelo usuário
        /// </summary>
        /// <param name="alternativa">0 - Nada selecionado, 1 - A, 2 - B, 3 - C, 4 - D</param>
        private void selecionarAlternativa(int alternativa)
        {
            switch (alternativa)
            {
                case 0:
                    AlternativaSelecionada = "";
                    configurarBotoes(0, 0, 0, 0);
                    break;
                case 1:
                    AlternativaSelecionada = "A";
                    configurarBotoes(1, 0, 0, 0);
                    break;
                case 2:
                    AlternativaSelecionada = "B";
                    configurarBotoes(0, 1, 0, 0);
                    break;
                case 3:
                    AlternativaSelecionada = "C";
                    configurarBotoes(0, 0, 1, 0);
                    break;
                case 4:
                    AlternativaSelecionada = "D";
                    configurarBotoes(0, 0, 0, 1);
                    break;
            }
        }

        private void btnAlternativaA_Click(object sender, EventArgs e)
        {
            selecionarAlternativa(1);
        }

        private void btnAlternativaB_Click(object sender, EventArgs e)
        {
            selecionarAlternativa(2);
        }

        private void btnAlternativaC_Click(object sender, EventArgs e)
        {
            selecionarAlternativa(3);
        }

        private void btnAlternativaD_Click(object sender, EventArgs e)
        {
            selecionarAlternativa(4);
        }
        /// <summary>
        /// Método responsável por fazer a atualização de dados na tela
        /// </summary>
        private void AtualizarDadosTela()
        {
            Console.WriteLine("Iniciando atualização de dados na tela...");
            
            //parando o timer para configurar os dados na tela
            tmrQuiz.Stop();

            //configurando os dados na tela
            lblNumeroQuestao.Text = (pergunta.Numero).ToString().PadLeft(2,'0');
            txtbxQuestao.Text = pergunta.Questao.ToUpper();
            txtbxAlternativaA.Text = pergunta.AlternativaA.ToUpper();
            txtbxAlternativaB.Text = pergunta.AlternativaB.ToUpper();
            txtbxAlternativaC.Text = pergunta.AlternativaC.ToUpper();
            txtbxAlternativaD.Text = pergunta.AlternativaD.ToUpper();           

            pnlResultado.BackgroundImage = null;
            lblJogador.Text = "Jogador: " + jogador.Nome.ToUpper();
            lblPontuacao.Text = "Pontuação: " + jogador.Acertos.ToString() + "pts";
            lblPercentualAcerto.Text = "Acertos: " + jogador.PercAcertos.ToString("0.00") + "%";
            lblPercentualErros.Text = "Erros: " + jogador.PercErros.ToString("0.00") + "%";
            //valendoooooo
            tmrQuiz.Start();
        }

        private void btnProximaQuestao_Click(object sender, EventArgs e)
        {
            ChamarProximaQuestao();
        }

        private void FrmQuiz_Shown(object sender, EventArgs e)
        {
            AtualizarDadosTela();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total: " + (ListaPerguntas.Count-1).ToString());
        }
    }
}
