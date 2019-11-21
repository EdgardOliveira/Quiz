using N2Quiz.controllers;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace N2Quiz
{
    public partial class frmPrincipal : Form
    {
        /// <summary>
        /// Construtor da classe
        /// </summary>
        public frmPrincipal()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Método responsável por abrir a tela de cadastro de jogador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Método responsável por carregar os dados do arquivo e mostrar no datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportar_Click(object sender, EventArgs e)
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

        /// <summary>
        /// Método responsável por abrir a tela de ranking para mostrar a classificação dos jogadores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void btnPergunta_Click(object sender, EventArgs e)
        {
            FrmPergunta tela = new FrmPergunta();
            tela.Show();
        }

        public void BarExample()
        {

            //Chart chartControl = new Chart();
            this.chartControl.Width = 100;
            this.chartControl.Height = 200;

            this.chartControl.Series.Clear();

            //create another area and add it to the chart
            //ChartArea chartArea = new ChartArea("Ranking");
            //this.chartControl.ChartAreas.Add(chartArea);

            // Data arrays
            string[] seriesArray = { "Cat", "Dog", "Bird", "Monkey" };
            int[] pointsArray = { 2, 1, 7, 5 };

            // Set palette
            this.chartControl.Palette = ChartColorPalette.EarthTones;

            // Set title
            this.chartControl.Titles.Add("Classificação");

            // Add series.
            for (int i = 0; i < seriesArray.Length; i++)
            {
                Series series = this.chartControl.Series.Add(seriesArray[i]);
                series.Points.Add(pointsArray[i]);
            }
            //this.chartControl.Series["Ranking"].Label = "#PERCENT{P0}";
        }

        private void btnGraficoBarras_Click(object sender, EventArgs e)
        {

            int[] xJogadores = new int[3];// { 1, 2, 3 };
            double[] yPontuacao = new double[3];// { 70, 100, 50 };
            string[] jogadores = new string[3];

            //definir o caminho do arquivo
            string CaminhoCompleto = Path.Combine(Application.StartupPath, Globais.ARQ_RANKING);
            
            //verificar se o arquivo existe
            if (File.Exists(CaminhoCompleto))
            {
                //ler arquivo de ranking
                Arquivo arquivo = new Arquivo();
                DataTable dataTable = arquivo.Abrir(Application.StartupPath, Globais.ARQ_RANKING);

                //ordenar pela pontuacao (maior para menor)
                dataTable.DefaultView.Sort = "Pontuacao desc";
                dataTable = dataTable.DefaultView.ToTable();

                //pegar os 3 primeiros e atribuir aos vetores x e y
                for (int i = 0; i < 3; i++)
                {
                    xJogadores[i] = i + 1;
                    yPontuacao[i] = Convert.ToDouble(dataTable.Rows[i]["Pontuacao"]);
                    jogadores[i] = dataTable.Rows[i]["Jogador"].ToString(); 
                }

                //Gráfico de Barras Vertical
                //create another area and add it to the chart
                ChartArea chartArea = new ChartArea("Ranking");
                chart1.ChartAreas.Add(chartArea);

                //Criando a série do eixo xy
                Series series = new Series();
                series.Points.DataBindXY(xJogadores, yPontuacao);
                //Legend secondLegend = new Legend("Primeiro");
                
                //chart1.Legends.Add("Testeeeee");

                //chartArea.Series[0].Legend = "Primeiro";
                //chartArea.Series[1].Legend = "Segundo";
                //chartArea.Series[2].Legend = "Terceiro";

                //Configura o tipo de gráfico, colunas; barras verticais
                series.ChartType = SeriesChartType.Column;
                series.ChartArea = "Ranking";

                //Add the series to the chart
                chart1.Series.Add(series);

                chart1.Visible = true;
            }
            else
            {
                MessageBox.Show("O arquivo de ranking não foi encontrado em " + CaminhoCompleto, "Arquivo não existe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BarExample();
        }
    }
}
