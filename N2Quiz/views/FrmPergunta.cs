using N2Quiz.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2Quiz
{
    public partial class FrmPergunta : Form
    {
        private int SelecaoResposta = 0;

        public FrmPergunta()
        {
            InitializeComponent();
        }

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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarDados())
            {
                Pergunta pergunta = new Pergunta();
                pergunta.Questao = txtbxPergunta.Text;
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
                pergunta.AlternativaA = txtbxAlternativaA.Text;
                pergunta.AlternativaB = txtbxAlternativaB.Text;
                pergunta.AlternativaC = txtbxAlternativaC.Text;
                pergunta.AlternativaD = txtbxAlternativaD.Text;

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

        private void rdbtnAlternativaA_CheckedChanged(object sender, EventArgs e)
        {
            SelecaoResposta = 1; //A
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SelecaoResposta = 2; //B
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SelecaoResposta = 3; //C
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            SelecaoResposta = 4; //D
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
