using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using N2Quiz.controllers;

namespace N2Quiz
{
    public partial class FrmImportar : Form
    {
        /// <summary>
        /// Construtor da classe
        /// </summary>
        public FrmImportar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método responsável por carregar os dados no datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportar_Click(object sender, EventArgs e)
        {
            string CaminhoCompleto = Path.Combine(Application.StartupPath, Globais.ARQ_PERGUNTAS);
            if (File.Exists(CaminhoCompleto))
            {
                Importar importarArquivo = new Importar(Application.StartupPath, Globais.ARQ_PERGUNTAS);

                dataGridViewPerguntas.DataSource = importarArquivo.CarregarDados();
                dataGridViewPerguntas.RowsDefaultCellStyle.BackColor = Color.Gray;
                dataGridViewPerguntas.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
                dataGridViewPerguntas.DefaultCellStyle.Font = new Font("Arial", 12);
                dataGridViewPerguntas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //dataGridViewPerguntas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                //dataGridViewPerguntas.AllowUserToOrderColumns = true;
                //dataGridViewPerguntas.AllowUserToResizeColumns = true;
                dataGridViewPerguntas.Sort(dataGridViewPerguntas.Columns["Numero"], ListSortDirection.Ascending);
            }
            else
            {
                MessageBox.Show("O arquivo de perguntas não foi encontrado em " + CaminhoCompleto);
            }
        }
    }
}
