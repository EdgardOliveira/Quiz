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
        private Importar ImportarArquivo { get; set; }

        private int Numero;

        /// <summary>
        /// Construtor com parâmetros da classe
        /// </summary>
        /// <param name="jogador">Recebe um jogador</param>
        public FrmQuiz(Jogador jogador)
        {
            InitializeComponent();

            this.jogador = jogador;

            ListaPerguntas = new List<Pergunta>();

            ImportarArquivo = new Importar(Application.StartupPath, Globais.ARQ_PERGUNTAS);

            DataTable dataTable = ImportarArquivo.CarregarDados();
            
            //Convertendo a tabela em lista
            ImportarArquivo.ConvertDataTableToList(dataTable);
            
            //atribuinda os dados da lista
            ListaPerguntas = ImportarArquivo.ListaPerguntas;
            
            //posicionando na primeira pergunta
            Numero = 0;
            
            //carregando dados da primeira pergunta
            pergunta = ListaPerguntas[Numero];
        }

        /// <summary>
        /// Método responsável por fazer a verificação da resposta do usuário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerificarResposta_Click(object sender, EventArgs e)
        {
            DateTime dt = Convert.ToDateTime("00:" + lblTempo.Text);
            int segundos = dt.Second;

            if (pergunta.VerificarResposta(segundos, AlternativaSelecionada))
            {
                //resposta correta...
                pnlResultado.BackgroundImage = Properties.Resources.acertomizeravi;
                Application.DoEvents();

                //quantidade de questoes que o jogador acertou
                jogador.NumeroQuestoes++;

                //incrimenta a pontuação do jogador (%)
                jogador.Pontuacao = CalcularPercentual(jogador.NumeroQuestoes, pergunta.Numero);
                               
                //habilita o botão próxima questão
                btnProximaQuestao.Visible = true;
                
                //ir para a próxima pergunta
                ChamarProximaQuestao();
            }
            else
            {
                //resposta incorreta...
                pnlResultado.BackgroundImage = Properties.Resources.errou;
                Application.DoEvents();
                //incrimenta a pontuação do jogador (%)
                jogador.Pontuacao = CalcularPercentual(jogador.NumeroQuestoes, pergunta.Numero);

                btnProximaQuestao.Visible = false;
                //ir para a próxima pergunta
                ChamarProximaQuestao();
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

        /// <summary>
        /// Método que verifica o tempo do usuário a cada segundo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrQuiz_Tick(object sender, EventArgs e)
        {
            if (pergunta.Tempo > 0)
            {
                pergunta.Tempo--;
                lblTempo.Text = "00:" + pergunta.Tempo.ToString().PadLeft(2,'0');
                if (pergunta.Tempo > 10)
                    lblTempo.ForeColor = Color.White;
                else if (pergunta.Tempo > 5)
                {
                    if ((lblTempo.ForeColor == Color.White) || (lblTempo.ForeColor == Color.Black))
                        lblTempo.ForeColor = Color.Yellow;
                    else if (lblTempo.ForeColor == Color.Yellow)
                        lblTempo.ForeColor = Color.Black;
                }                    
                else
                    if ((lblTempo.ForeColor == Color.Yellow) || (lblTempo.ForeColor == Color.Black))
                        lblTempo.ForeColor = Color.Red;
                    else if (lblTempo.ForeColor == Color.Red)
                        lblTempo.ForeColor = Color.Black;

                btnVerificarResposta.Visible = true;
            }
            else
            {
                if (String.IsNullOrEmpty(AlternativaSelecionada)) 
                {
                    pnlResultado.BackgroundImage = Properties.Resources.erroufeioerrourude;
                    Application.DoEvents();

                    btnVerificarResposta.Visible = false;
                    if (Numero < ListaPerguntas.Count - 1)
                        ChamarProximaQuestao();
                }
            }
        }
        /// <summary>
        /// Método responsável por carregar os dados da próxima pergunta
        /// </summary>
        private void ChamarProximaQuestao()
        {
            Thread.Sleep(3000); // 3segundos
            Application.DoEvents();

            if (Numero < ListaPerguntas.Count-1)
            {
                Numero++;
                pergunta = new Pergunta();
                pergunta = ListaPerguntas[Numero];
                selecionarAlternativa(0);
                AtualizarDadosTela();
            }
            else
            {
                AtualizarDadosTela();
                SalvarResultado();
            }
        }

        /// <summary>
        /// Método responsável por salvar a pontuação do jogador e mostrar o ranking
        /// </summary>
        private void SalvarResultado()
        {
            Arquivo arquivo = new Arquivo();
            arquivo.SalvarRanking(jogador, Application.StartupPath, Globais.ARQ_RANKING);

            MessageBox.Show("Fim de jogo.", "FIM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tmrQuiz.Enabled = false;

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
            lblNumeroQuestao.Text = pergunta.Numero.ToString().PadLeft(2,'0');
            txtbxQuestao.Text = pergunta.Questao.ToUpper();
            lblAlternativaA.Text = pergunta.AlternativaA.ToUpper();
            lblAlternativaB.Text = pergunta.AlternativaB.ToUpper();
            lblAlternativaC.Text = pergunta.AlternativaC.ToUpper();
            lblAlternativaD.Text = pergunta.AlternativaD.ToUpper();
            pergunta.Tempo = 31;
            pnlResultado.BackgroundImage = null;
            lblJogador.Text = "Jogador: " + jogador.Nome.ToUpper();
            lblPontuacao.Text = "Pontuação: " + jogador.NumeroQuestoes.ToString() + "pts";
            lblPercentualAcerto.Text = "Acertos: " + jogador.Pontuacao.ToString() + "%";
        }

        private void FrmQuiz_Activated(object sender, EventArgs e)
        {
            AtualizarDadosTela();
        }
    }
}
