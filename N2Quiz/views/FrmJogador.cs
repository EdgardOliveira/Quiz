using System;
using System.Windows.Forms;

namespace N2Quiz
{
    public partial class FrmJogador : Form
    {
        public FrmJogador()
        {
            InitializeComponent();
        }

        private bool ValidarCampos()
        {
            bool status = true;

            if (String.IsNullOrEmpty(txtbxNome.Text))
                status = false;

            return status;
        }

        private void btnRegistrarJogar_Click(object sender, EventArgs e)
        {
            
            if (ValidarCampos())
            {
                Jogador jogador = new Jogador(txtbxNome.Text.ToUpper(), 0, 0);
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

        private void FrmJogador_Activated(object sender, EventArgs e)
        {
            txtbxNome.Focus();
        }
    }
}
