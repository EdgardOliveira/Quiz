namespace N2Quiz
{
    partial class FrmQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuiz));
            this.tmrQuiz = new System.Windows.Forms.Timer(this.components);
            this.panelPergunta = new System.Windows.Forms.Panel();
            this.txtbxQuestao = new System.Windows.Forms.TextBox();
            this.lblNumeroQuestao = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAlternativaD = new System.Windows.Forms.Button();
            this.btnAlternativaC = new System.Windows.Forms.Button();
            this.btnAlternativaB = new System.Windows.Forms.Button();
            this.btnAlternativaA = new System.Windows.Forms.Button();
            this.pnlAlternativaD = new System.Windows.Forms.Panel();
            this.txtbxAlternativaD = new System.Windows.Forms.TextBox();
            this.pnlAlternativaC = new System.Windows.Forms.Panel();
            this.txtbxAlternativaC = new System.Windows.Forms.TextBox();
            this.pnlAlternativaB = new System.Windows.Forms.Panel();
            this.txtbxAlternativaB = new System.Windows.Forms.TextBox();
            this.pnlAlternativaA = new System.Windows.Forms.Panel();
            this.txtbxAlternativaA = new System.Windows.Forms.TextBox();
            this.lblTempo = new System.Windows.Forms.Label();
            this.btnVerificarResposta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPercentualErros = new System.Windows.Forms.Label();
            this.lblPercentualAcerto = new System.Windows.Forms.Label();
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.lblJogador = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblRanking = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDados = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pnlResultado = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelPergunta.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlAlternativaD.SuspendLayout();
            this.pnlAlternativaC.SuspendLayout();
            this.pnlAlternativaB.SuspendLayout();
            this.pnlAlternativaA.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrQuiz
            // 
            this.tmrQuiz.Enabled = true;
            this.tmrQuiz.Interval = 1000;
            this.tmrQuiz.Tick += new System.EventHandler(this.tmrQuiz_Tick);
            // 
            // panelPergunta
            // 
            this.panelPergunta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPergunta.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelPergunta.Controls.Add(this.txtbxQuestao);
            this.panelPergunta.Controls.Add(this.lblNumeroQuestao);
            this.panelPergunta.Location = new System.Drawing.Point(1, 1);
            this.panelPergunta.Name = "panelPergunta";
            this.panelPergunta.Size = new System.Drawing.Size(978, 103);
            this.panelPergunta.TabIndex = 0;
            // 
            // txtbxQuestao
            // 
            this.txtbxQuestao.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtbxQuestao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxQuestao.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxQuestao.ForeColor = System.Drawing.Color.GreenYellow;
            this.txtbxQuestao.Location = new System.Drawing.Point(105, 7);
            this.txtbxQuestao.Multiline = true;
            this.txtbxQuestao.Name = "txtbxQuestao";
            this.txtbxQuestao.Size = new System.Drawing.Size(958, 93);
            this.txtbxQuestao.TabIndex = 1;
            this.txtbxQuestao.Text = resources.GetString("txtbxQuestao.Text");
            // 
            // lblNumeroQuestao
            // 
            this.lblNumeroQuestao.AutoSize = true;
            this.lblNumeroQuestao.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNumeroQuestao.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroQuestao.ForeColor = System.Drawing.Color.White;
            this.lblNumeroQuestao.Location = new System.Drawing.Point(0, 0);
            this.lblNumeroQuestao.Name = "lblNumeroQuestao";
            this.lblNumeroQuestao.Size = new System.Drawing.Size(104, 75);
            this.lblNumeroQuestao.TabIndex = 0;
            this.lblNumeroQuestao.Text = "##";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.btnAlternativaD);
            this.panel2.Controls.Add(this.btnAlternativaC);
            this.panel2.Controls.Add(this.btnAlternativaB);
            this.panel2.Controls.Add(this.btnAlternativaA);
            this.panel2.Controls.Add(this.pnlAlternativaD);
            this.panel2.Controls.Add(this.pnlAlternativaC);
            this.panel2.Controls.Add(this.pnlAlternativaB);
            this.panel2.Controls.Add(this.pnlAlternativaA);
            this.panel2.Location = new System.Drawing.Point(1, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(727, 373);
            this.panel2.TabIndex = 2;
            // 
            // btnAlternativaD
            // 
            this.btnAlternativaD.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAlternativaD.Font = new System.Drawing.Font("Arial Black", 32F, System.Drawing.FontStyle.Bold);
            this.btnAlternativaD.ForeColor = System.Drawing.Color.White;
            this.btnAlternativaD.Location = new System.Drawing.Point(9, 276);
            this.btnAlternativaD.Name = "btnAlternativaD";
            this.btnAlternativaD.Size = new System.Drawing.Size(85, 85);
            this.btnAlternativaD.TabIndex = 12;
            this.btnAlternativaD.Text = "D";
            this.btnAlternativaD.UseVisualStyleBackColor = false;
            this.btnAlternativaD.Click += new System.EventHandler(this.btnAlternativaD_Click);
            // 
            // btnAlternativaC
            // 
            this.btnAlternativaC.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAlternativaC.Font = new System.Drawing.Font("Arial Black", 32F, System.Drawing.FontStyle.Bold);
            this.btnAlternativaC.ForeColor = System.Drawing.Color.White;
            this.btnAlternativaC.Location = new System.Drawing.Point(9, 188);
            this.btnAlternativaC.Name = "btnAlternativaC";
            this.btnAlternativaC.Size = new System.Drawing.Size(85, 85);
            this.btnAlternativaC.TabIndex = 11;
            this.btnAlternativaC.Text = "C";
            this.btnAlternativaC.UseVisualStyleBackColor = false;
            this.btnAlternativaC.Click += new System.EventHandler(this.btnAlternativaC_Click);
            // 
            // btnAlternativaB
            // 
            this.btnAlternativaB.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAlternativaB.Font = new System.Drawing.Font("Arial Black", 32F, System.Drawing.FontStyle.Bold);
            this.btnAlternativaB.ForeColor = System.Drawing.Color.White;
            this.btnAlternativaB.Location = new System.Drawing.Point(9, 99);
            this.btnAlternativaB.Name = "btnAlternativaB";
            this.btnAlternativaB.Size = new System.Drawing.Size(85, 85);
            this.btnAlternativaB.TabIndex = 10;
            this.btnAlternativaB.Text = "B";
            this.btnAlternativaB.UseVisualStyleBackColor = false;
            this.btnAlternativaB.Click += new System.EventHandler(this.btnAlternativaB_Click);
            // 
            // btnAlternativaA
            // 
            this.btnAlternativaA.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAlternativaA.Font = new System.Drawing.Font("Arial Black", 32F, System.Drawing.FontStyle.Bold);
            this.btnAlternativaA.ForeColor = System.Drawing.Color.White;
            this.btnAlternativaA.Location = new System.Drawing.Point(9, 10);
            this.btnAlternativaA.Name = "btnAlternativaA";
            this.btnAlternativaA.Size = new System.Drawing.Size(85, 85);
            this.btnAlternativaA.TabIndex = 9;
            this.btnAlternativaA.Text = "A";
            this.btnAlternativaA.UseVisualStyleBackColor = false;
            this.btnAlternativaA.Click += new System.EventHandler(this.btnAlternativaA_Click);
            // 
            // pnlAlternativaD
            // 
            this.pnlAlternativaD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlAlternativaD.Controls.Add(this.txtbxAlternativaD);
            this.pnlAlternativaD.Location = new System.Drawing.Point(90, 277);
            this.pnlAlternativaD.Name = "pnlAlternativaD";
            this.pnlAlternativaD.Size = new System.Drawing.Size(624, 83);
            this.pnlAlternativaD.TabIndex = 8;
            // 
            // txtbxAlternativaD
            // 
            this.txtbxAlternativaD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxAlternativaD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtbxAlternativaD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxAlternativaD.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxAlternativaD.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtbxAlternativaD.Location = new System.Drawing.Point(7, 12);
            this.txtbxAlternativaD.Multiline = true;
            this.txtbxAlternativaD.Name = "txtbxAlternativaD";
            this.txtbxAlternativaD.Size = new System.Drawing.Size(611, 58);
            this.txtbxAlternativaD.TabIndex = 5;
            this.txtbxAlternativaD.Text = "RESPOSTA DA LETRA D";
            // 
            // pnlAlternativaC
            // 
            this.pnlAlternativaC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlAlternativaC.Controls.Add(this.txtbxAlternativaC);
            this.pnlAlternativaC.Location = new System.Drawing.Point(90, 189);
            this.pnlAlternativaC.Name = "pnlAlternativaC";
            this.pnlAlternativaC.Size = new System.Drawing.Size(624, 83);
            this.pnlAlternativaC.TabIndex = 6;
            // 
            // txtbxAlternativaC
            // 
            this.txtbxAlternativaC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxAlternativaC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtbxAlternativaC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxAlternativaC.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxAlternativaC.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtbxAlternativaC.Location = new System.Drawing.Point(8, 13);
            this.txtbxAlternativaC.Multiline = true;
            this.txtbxAlternativaC.Name = "txtbxAlternativaC";
            this.txtbxAlternativaC.Size = new System.Drawing.Size(613, 58);
            this.txtbxAlternativaC.TabIndex = 4;
            this.txtbxAlternativaC.Text = "RESPOSTA DA LETRA C";
            // 
            // pnlAlternativaB
            // 
            this.pnlAlternativaB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlAlternativaB.Controls.Add(this.txtbxAlternativaB);
            this.pnlAlternativaB.Location = new System.Drawing.Point(90, 100);
            this.pnlAlternativaB.Name = "pnlAlternativaB";
            this.pnlAlternativaB.Size = new System.Drawing.Size(624, 83);
            this.pnlAlternativaB.TabIndex = 4;
            // 
            // txtbxAlternativaB
            // 
            this.txtbxAlternativaB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxAlternativaB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtbxAlternativaB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxAlternativaB.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxAlternativaB.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtbxAlternativaB.Location = new System.Drawing.Point(8, 14);
            this.txtbxAlternativaB.Multiline = true;
            this.txtbxAlternativaB.Name = "txtbxAlternativaB";
            this.txtbxAlternativaB.Size = new System.Drawing.Size(613, 58);
            this.txtbxAlternativaB.TabIndex = 3;
            this.txtbxAlternativaB.Text = "RESPOSTA DA LETRA B";
            // 
            // pnlAlternativaA
            // 
            this.pnlAlternativaA.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAlternativaA.Controls.Add(this.txtbxAlternativaA);
            this.pnlAlternativaA.Location = new System.Drawing.Point(90, 11);
            this.pnlAlternativaA.Name = "pnlAlternativaA";
            this.pnlAlternativaA.Size = new System.Drawing.Size(624, 83);
            this.pnlAlternativaA.TabIndex = 2;
            // 
            // txtbxAlternativaA
            // 
            this.txtbxAlternativaA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxAlternativaA.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtbxAlternativaA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxAlternativaA.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxAlternativaA.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtbxAlternativaA.Location = new System.Drawing.Point(6, 15);
            this.txtbxAlternativaA.Multiline = true;
            this.txtbxAlternativaA.Name = "txtbxAlternativaA";
            this.txtbxAlternativaA.Size = new System.Drawing.Size(615, 58);
            this.txtbxAlternativaA.TabIndex = 2;
            this.txtbxAlternativaA.Text = "RESPOSTA DA LETRA A";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTempo.Location = new System.Drawing.Point(877, 10);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(153, 111);
            this.lblTempo.TabIndex = 3;
            this.lblTempo.Text = "30";
            this.lblTempo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnVerificarResposta
            // 
            this.btnVerificarResposta.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarResposta.Location = new System.Drawing.Point(480, 486);
            this.btnVerificarResposta.Name = "btnVerificarResposta";
            this.btnVerificarResposta.Size = new System.Drawing.Size(248, 46);
            this.btnVerificarResposta.TabIndex = 5;
            this.btnVerificarResposta.Text = "Verificar Resposta";
            this.btnVerificarResposta.UseVisualStyleBackColor = true;
            this.btnVerificarResposta.Click += new System.EventHandler(this.btnVerificarResposta_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.lblPercentualErros);
            this.panel1.Controls.Add(this.lblPercentualAcerto);
            this.panel1.Controls.Add(this.lblPontuacao);
            this.panel1.Controls.Add(this.lblJogador);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblRanking);
            this.panel1.Controls.Add(this.lblTempo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1324, 121);
            this.panel1.TabIndex = 7;
            // 
            // lblPercentualErros
            // 
            this.lblPercentualErros.AutoSize = true;
            this.lblPercentualErros.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentualErros.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPercentualErros.Location = new System.Drawing.Point(546, 49);
            this.lblPercentualErros.Name = "lblPercentualErros";
            this.lblPercentualErros.Size = new System.Drawing.Size(196, 39);
            this.lblPercentualErros.TabIndex = 10;
            this.lblPercentualErros.Text = "Erros: XX,X%";
            this.lblPercentualErros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPercentualErros.Visible = false;
            // 
            // lblPercentualAcerto
            // 
            this.lblPercentualAcerto.AutoSize = true;
            this.lblPercentualAcerto.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentualAcerto.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPercentualAcerto.Location = new System.Drawing.Point(199, 49);
            this.lblPercentualAcerto.Name = "lblPercentualAcerto";
            this.lblPercentualAcerto.Size = new System.Drawing.Size(244, 39);
            this.lblPercentualAcerto.TabIndex = 8;
            this.lblPercentualAcerto.Text = "Acertos: XX,X%";
            this.lblPercentualAcerto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontuacao.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPontuacao.Location = new System.Drawing.Point(199, 10);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(281, 39);
            this.lblPontuacao.TabIndex = 7;
            this.lblPontuacao.Text = "Pontuação: 0 pts";
            this.lblPontuacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJogador
            // 
            this.lblJogador.AutoSize = true;
            this.lblJogador.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador.ForeColor = System.Drawing.Color.SlateGray;
            this.lblJogador.Location = new System.Drawing.Point(12, 79);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(168, 39);
            this.lblJogador.TabIndex = 6;
            this.lblJogador.Text = "Jogador: ";
            this.lblJogador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1054, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 100);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblRanking
            // 
            this.lblRanking.AutoSize = true;
            this.lblRanking.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRanking.ForeColor = System.Drawing.Color.White;
            this.lblRanking.Location = new System.Drawing.Point(3, 0);
            this.lblRanking.Name = "lblRanking";
            this.lblRanking.Size = new System.Drawing.Size(169, 78);
            this.lblRanking.TabIndex = 4;
            this.lblRanking.Text = "Quiz";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.panel3.Controls.Add(this.lblDados);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1324, 44);
            this.panel3.TabIndex = 9;
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDados.ForeColor = System.Drawing.Color.White;
            this.lblDados.Location = new System.Drawing.Point(579, 2);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(160, 39);
            this.lblDados.TabIndex = 5;
            this.lblDados.Text = "Pergunta";
            this.lblDados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.pnlResultado);
            this.panel8.Controls.Add(this.btnVerificarResposta);
            this.panel8.Controls.Add(this.panelPergunta);
            this.panel8.Controls.Add(this.panel2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(337, 165);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(987, 550);
            this.panel8.TabIndex = 19;
            // 
            // pnlResultado
            // 
            this.pnlResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlResultado.BackgroundImage = global::N2Quiz.Properties.Resources.erroufeioerrourude;
            this.pnlResultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlResultado.Location = new System.Drawing.Point(734, 105);
            this.pnlResultado.Name = "pnlResultado";
            this.pnlResultado.Size = new System.Drawing.Size(245, 426);
            this.pnlResultado.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 165);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(337, 550);
            this.panel6.TabIndex = 18;
            // 
            // FrmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1324, 715);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FrmQuiz_Shown);
            this.panelPergunta.ResumeLayout(false);
            this.panelPergunta.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlAlternativaD.ResumeLayout(false);
            this.pnlAlternativaD.PerformLayout();
            this.pnlAlternativaC.ResumeLayout(false);
            this.pnlAlternativaC.PerformLayout();
            this.pnlAlternativaB.ResumeLayout(false);
            this.pnlAlternativaB.PerformLayout();
            this.pnlAlternativaA.ResumeLayout(false);
            this.pnlAlternativaA.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrQuiz;
        private System.Windows.Forms.Panel panelPergunta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlAlternativaD;
        private System.Windows.Forms.Panel pnlAlternativaC;
        private System.Windows.Forms.Panel pnlAlternativaB;
        private System.Windows.Forms.Panel pnlAlternativaA;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.TextBox txtbxQuestao;
        private System.Windows.Forms.Label lblNumeroQuestao;
        private System.Windows.Forms.Button btnAlternativaD;
        private System.Windows.Forms.Button btnAlternativaC;
        private System.Windows.Forms.Button btnAlternativaB;
        private System.Windows.Forms.Button btnAlternativaA;
        private System.Windows.Forms.Button btnVerificarResposta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRanking;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel pnlResultado;
        private System.Windows.Forms.Label lblPercentualAcerto;
        private System.Windows.Forms.Label lblPontuacao;
        private System.Windows.Forms.Label lblJogador;
        private System.Windows.Forms.Label lblPercentualErros;
        private System.Windows.Forms.TextBox txtbxAlternativaC;
        private System.Windows.Forms.TextBox txtbxAlternativaB;
        private System.Windows.Forms.TextBox txtbxAlternativaA;
        private System.Windows.Forms.TextBox txtbxAlternativaD;
    }
}