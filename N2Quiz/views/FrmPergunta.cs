using N2Quiz.controllers;
using System;
using System.Windows.Forms;

namespace N2Quiz
{
    public partial class FrmPergunta : Form
    {
        /// <summary>
        /// Atributos
        /// </summary>
        private int SelecaoResposta = 0;

        /// <summary>
        /// Construtor da classe
        /// </summary>
        public FrmPergunta()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método responsável por validar os dados inseridos pelo usuário na tela
        /// </summary>
        /// <returns>false - se os dados são inválidos, true - se os dados são válidos</returns>
        private bool ValidarDados()
        {
            bool status = true;

            if (String.IsNullOrEmpty(txtbxPergunta.Text))
                status = false;

            if (String.IsNullOrEmpty(txtbxAlternativaA.Text))
                status = false;

            if (String.IsNullOrEmpty(txtbxAlternativaB.Text))
                status = false;

            if (String.IsNullOrEmpty(txtbxAlternativaC.Text))
                status = false;

            if (String.IsNullOrEmpty(txtbxAlternativaD.Text))
                status = false;

            switch (SelecaoResposta)
            {
                case 0:
                    status = false;
                    break;
            }

            return status;
        }
        /// <summary>
        /// Método responsável por salvar os dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarDados())
            {
                Pergunta pergunta = new Pergunta();
                pergunta.Questao = txtbxPergunta.Text.ToUpper();
                switch (SelecaoResposta)
                {
                    case 1:
                        pergunta.Resposta = "A";
                        break;
                    case 2:
                        pergunta.Resposta = "B";
                        break;
                    case 3:
                        pergunta.Resposta = "C";
                        break;
                    case 4:
                        pergunta.Resposta = "D";
                        break;
                }
                pergunta.AlternativaA = txtbxAlternativaA.Text.ToUpper();
                pergunta.AlternativaB = txtbxAlternativaB.Text.ToUpper();
                pergunta.AlternativaC = txtbxAlternativaC.Text.ToUpper();
                pergunta.AlternativaD = txtbxAlternativaD.Text.ToUpper();

                Arquivo arquivo = new Arquivo();
                if (arquivo.SalvarPergunta(pergunta, Application.StartupPath, Globais.ARQ_PERGUNTAS))
                    if (MessageBox.Show("Pergunta salva com sucesso", "Pergunta cadastrada", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        this.Dispose();
                    else
                    {
                        MessageBox.Show("Não foi possível salvar a pergunta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
            }
            else
            {
                MessageBox.Show("É necessário preencher todos os dados para concluir.", "Erro de preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /// <summary>
        /// Método responsável por marcar a seleção da resposta certa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbtnAlternativaA_CheckedChanged(object sender, EventArgs e)
        {
            SelecaoResposta = 1; //A
        }
        /// <summary>
        /// Método responsável por marcar a seleção da resposta certa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SelecaoResposta = 2; //B
        }
        /// <summary>
        /// Método responsável por marcar a seleção da resposta certa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SelecaoResposta = 3; //C
        }

        /// <summary>
        /// Método responsável por marcar a seleção da resposta certa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            SelecaoResposta = 4; //D
        }
        /// <summary>
        /// Método responsável por fechar a tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
