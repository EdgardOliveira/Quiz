﻿using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace N2Quiz
{
    public partial class FrmJogador : Form
    {
        /// <summary>
        /// Construtor da classe
        /// </summary>
        public FrmJogador()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método responsável por validar os dados inseridos pelo usuário na tela
        /// </summary>
        /// <returns>false - se os dados são inválidos, true - se os dados estão válidos</returns>
        private bool ValidarCampos()
        {
            bool status = true;

            if ((String.IsNullOrEmpty(txtbxNome.Text)) || (txtbxNome.Text.Length<5))
                status = false;

            return status;
        }

        /// <summary>
        /// Método responsável por registrar o jogador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistrarJogar_Click(object sender, EventArgs e)
        {
            
            if (ValidarCampos())
            {
                Jogador jogador = new Jogador(txtbxNome.Text.ToUpper(), 0, 0, 0, 0);
                FrmQuiz tela = new FrmQuiz(jogador);
                this.Dispose();
                tela.Show();
            }
            else
            {
                MessageBox.Show("Informe o nome do jogador para continuar!");
                txtbxNome.Focus();
            }            
        }

        private void FrmJogador_Shown(object sender, EventArgs e)
        {
            txtbxNome.Focus();
        }

        private void txtbxNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            //bloqueando caracteres especiais
            /**var regex = new Regex(@"[^a-zA-Z0-9\s]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }**/

            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);

            //enter como tecla tab
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                SendKeys.Send("{tab}");
            }
        }
    }
}
