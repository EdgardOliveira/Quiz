using N2Quiz.controllers;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace N2Quiz
{
    public partial class FrmRanking : Form
    {
        public FrmRanking()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            string CaminhoCompleto = Path.Combine(Application.StartupPath, Globais.ARQ_RANKING);
            if (File.Exists(CaminhoCompleto))
            {
                Arquivo arquivo = new Arquivo();
                dataGridViewRanking.DataSource = arquivo.Abrir(Application.StartupPath, Globais.ARQ_RANKING);
                dataGridViewRanking.RowsDefaultCellStyle.BackColor = Color.Gray;
                dataGridViewRanking.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
                dataGridViewRanking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewRanking.DefaultCellStyle.Font = new Font("Arial", 12);

                //dataGridViewRanking.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                //dataGridViewRanking.AllowUserToOrderColumns = true;
                //dataGridViewRanking.AllowUserToResizeColumns = true;
                dataGridViewRanking.Sort(dataGridViewRanking.Columns["Questoes"], ListSortDirection.Descending);
            }
            else
            {
                if (MessageBox.Show("O arquivo de ranking não foi encontrado em " + CaminhoCompleto, "Arquivo não existe", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    this.Dispose();                     
            }
        }
    }
}
