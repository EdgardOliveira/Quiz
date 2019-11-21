using N2Quiz.controllers;
using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace N2Quiz
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            string CaminhoCompleto = Path.Combine(Application.StartupPath, Globais.ARQ_PERGUNTAS);
            if (File.Exists(CaminhoCompleto))
            {
                FrmJogador tela = new FrmJogador();
                tela.Show();
            }
            else
            {
                MessageBox.Show("O arquivo de perguntas não foi encontrado em " + CaminhoCompleto, "Arquivo não existe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CaminhoCompleto = Path.Combine(Application.StartupPath, Globais.ARQ_PERGUNTAS);
            if (File.Exists(CaminhoCompleto))
            {
                FrmImportar tela = new FrmImportar();
                tela.Show();
            }
            else
            {
                MessageBox.Show("O arquivo de perguntas não foi encontrado em " + CaminhoCompleto, "Arquivo não existe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Jogador jogador = new Jogador();
            jogador.Nome = "Edgard Oliveira";
            jogador.NumeroQuestoes = 20;
            jogador.Pontuacao = 100;

            Arquivo arquivo = new Arquivo();
            arquivo.SalvarRanking(jogador, Application.StartupPath, Globais.ARQ_RANKING);
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            string CaminhoCompleto = Path.Combine(Application.StartupPath, Globais.ARQ_RANKING);
            if (File.Exists(CaminhoCompleto))
            {

                FrmRanking tela = new FrmRanking();
                tela.Show();
            }
            else
            {
                MessageBox.Show("O arquivo de ranking não foi encontrado em " + CaminhoCompleto, "Arquivo não existe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            double[] xJogadores = new double[] { 1, 2, 3 };
            double[] yPontuacao = new double[] { 70, 100, 50 };

            //Gráfico de Barras Vertical
            //create another area and add it to the chart
            ChartArea chartArea = new ChartArea("Ranking");
            chart1.ChartAreas.Add(chartArea);

            //Criando a série do eixo y
            Series series = new Series();
            //series.Points.DataBindY(yPontuacao);
            series.Points.DataBindXY(xJogadores, yPontuacao);            

            //Configura o tipo de gráfico, colunas; barras verticais
            series.ChartType = SeriesChartType.Column;
            series.ChartArea = "Ranking";

            //Add the series to the chart
            chart1.Series.Add(series);
            
        }

        private void btnPergunta_Click(object sender, EventArgs e)
        {
            FrmPergunta tela = new FrmPergunta();
            tela.Show();
        }
    }
}
