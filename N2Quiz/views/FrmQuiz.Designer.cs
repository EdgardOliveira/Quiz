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
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblAlternativaD = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblAlternativaC = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblAlternativaB = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblAlternativaA = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnProximaQuestao = new System.Windows.Forms.Button();
            this.btnVerificarResposta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.panelPergunta.Location = new System.Drawing.Point(34, 16);
            this.panelPergunta.Name = "panelPergunta";
            this.panelPergunta.Size = new System.Drawing.Size(990, 78);
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
            this.txtbxQuestao.Size = new System.Drawing.Size(861, 62);
            this.txtbxQuestao.TabIndex = 1;
            this.txtbxQuestao.Text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
    "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
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
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(34, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(589, 280);
            this.panel2.TabIndex = 2;
            // 
            // btnAlternativaD
            // 
            this.btnAlternativaD.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAlternativaD.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlternativaD.ForeColor = System.Drawing.Color.White;
            this.btnAlternativaD.Location = new System.Drawing.Point(31, 210);
            this.btnAlternativaD.Name = "btnAlternativaD";
            this.btnAlternativaD.Size = new System.Drawing.Size(56, 46);
            this.btnAlternativaD.TabIndex = 12;
            this.btnAlternativaD.Text = "D";
            this.btnAlternativaD.UseVisualStyleBackColor = false;
            this.btnAlternativaD.Click += new System.EventHandler(this.btnAlternativaD_Click);
            // 
            // btnAlternativaC
            // 
            this.btnAlternativaC.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAlternativaC.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlternativaC.ForeColor = System.Drawing.Color.White;
            this.btnAlternativaC.Location = new System.Drawing.Point(31, 148);
            this.btnAlternativaC.Name = "btnAlternativaC";
            this.btnAlternativaC.Size = new System.Drawing.Size(56, 46);
            this.btnAlternativaC.TabIndex = 11;
            this.btnAlternativaC.Text = "C";
            this.btnAlternativaC.UseVisualStyleBackColor = false;
            this.btnAlternativaC.Click += new System.EventHandler(this.btnAlternativaC_Click);
            // 
            // btnAlternativaB
            // 
            this.btnAlternativaB.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAlternativaB.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlternativaB.ForeColor = System.Drawing.Color.White;
            this.btnAlternativaB.Location = new System.Drawing.Point(32, 86);
            this.btnAlternativaB.Name = "btnAlternativaB";
            this.btnAlternativaB.Size = new System.Drawing.Size(56, 46);
            this.btnAlternativaB.TabIndex = 10;
            this.btnAlternativaB.Text = "B";
            this.btnAlternativaB.UseVisualStyleBackColor = false;
            this.btnAlternativaB.Click += new System.EventHandler(this.btnAlternativaB_Click);
            // 
            // btnAlternativaA
            // 
            this.btnAlternativaA.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAlternativaA.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlternativaA.ForeColor = System.Drawing.Color.White;
            this.btnAlternativaA.Location = new System.Drawing.Point(32, 24);
            this.btnAlternativaA.Name = "btnAlternativaA";
            this.btnAlternativaA.Size = new System.Drawing.Size(56, 46);
            this.btnAlternativaA.TabIndex = 9;
            this.btnAlternativaA.Text = "A";
            this.btnAlternativaA.UseVisualStyleBackColor = false;
            this.btnAlternativaA.Click += new System.EventHandler(this.btnAlternativaA_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel9.Controls.Add(this.lblAlternativaD);
            this.panel9.Location = new System.Drawing.Point(85, 210);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(462, 46);
            this.panel9.TabIndex = 8;
            // 
            // lblAlternativaD
            // 
            this.lblAlternativaD.AutoSize = true;
            this.lblAlternativaD.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlternativaD.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblAlternativaD.Location = new System.Drawing.Point(9, 10);
            this.lblAlternativaD.Name = "lblAlternativaD";
            this.lblAlternativaD.Size = new System.Drawing.Size(291, 29);
            this.lblAlternativaD.TabIndex = 3;
            this.lblAlternativaD.Text = "RESPOSTA DA LETRA D";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel7.Controls.Add(this.lblAlternativaC);
            this.panel7.Location = new System.Drawing.Point(85, 148);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(462, 46);
            this.panel7.TabIndex = 6;
            // 
            // lblAlternativaC
            // 
            this.lblAlternativaC.AutoSize = true;
            this.lblAlternativaC.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlternativaC.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblAlternativaC.Location = new System.Drawing.Point(9, 10);
            this.lblAlternativaC.Name = "lblAlternativaC";
            this.lblAlternativaC.Size = new System.Drawing.Size(291, 29);
            this.lblAlternativaC.TabIndex = 3;
            this.lblAlternativaC.Text = "RESPOSTA DA LETRA C";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.Controls.Add(this.lblAlternativaB);
            this.panel5.Location = new System.Drawing.Point(85, 86);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(462, 46);
            this.panel5.TabIndex = 4;
            // 
            // lblAlternativaB
            // 
            this.lblAlternativaB.AutoSize = true;
            this.lblAlternativaB.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlternativaB.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblAlternativaB.Location = new System.Drawing.Point(9, 10);
            this.lblAlternativaB.Name = "lblAlternativaB";
            this.lblAlternativaB.Size = new System.Drawing.Size(291, 29);
            this.lblAlternativaB.TabIndex = 3;
            this.lblAlternativaB.Text = "RESPOSTA DA LETRA B";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Controls.Add(this.lblAlternativaA);
            this.panel4.Location = new System.Drawing.Point(85, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(462, 46);
            this.panel4.TabIndex = 2;
            // 
            // lblAlternativaA
            // 
            this.lblAlternativaA.AutoSize = true;
            this.lblAlternativaA.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlternativaA.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblAlternativaA.Location = new System.Drawing.Point(9, 10);
            this.lblAlternativaA.Name = "lblAlternativaA";
            this.lblAlternativaA.Size = new System.Drawing.Size(290, 29);
            this.lblAlternativaA.TabIndex = 2;
            this.lblAlternativaA.Text = "RESPOSTA DA LETRA A";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTempo.Location = new System.Drawing.Point(740, 7);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(290, 111);
            this.lblTempo.TabIndex = 3;
            this.lblTempo.Text = "00:30";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(34, 375);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(590, 4);
            this.progressBar1.TabIndex = 0;
            // 
            // btnProximaQuestao
            // 
            this.btnProximaQuestao.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximaQuestao.Location = new System.Drawing.Point(473, 385);
            this.btnProximaQuestao.Name = "btnProximaQuestao";
            this.btnProximaQuestao.Size = new System.Drawing.Size(150, 70);
            this.btnProximaQuestao.TabIndex = 4;
            this.btnProximaQuestao.Text = "Próxima Questão";
            this.btnProximaQuestao.UseVisualStyleBackColor = true;
            this.btnProximaQuestao.Visible = false;
            // 
            // btnVerificarResposta
            // 
            this.btnVerificarResposta.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarResposta.Location = new System.Drawing.Point(317, 385);
            this.btnVerificarResposta.Name = "btnVerificarResposta";
            this.btnVerificarResposta.Size = new System.Drawing.Size(150, 70);
            this.btnVerificarResposta.TabIndex = 5;
            this.btnVerificarResposta.Text = "Verificar";
            this.btnVerificarResposta.UseVisualStyleBackColor = true;
            this.btnVerificarResposta.Click += new System.EventHandler(this.btnVerificarResposta_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.lblPercentualAcerto);
            this.panel1.Controls.Add(this.lblPontuacao);
            this.panel1.Controls.Add(this.lblJogador);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblRanking);
            this.panel1.Controls.Add(this.lblTempo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1306, 121);
            this.panel1.TabIndex = 7;
            // 
            // lblPercentualAcerto
            // 
            this.lblPercentualAcerto.AutoSize = true;
            this.lblPercentualAcerto.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentualAcerto.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPercentualAcerto.Location = new System.Drawing.Point(270, 48);
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
            this.lblPontuacao.Location = new System.Drawing.Point(270, 9);
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
            this.button1.Location = new System.Drawing.Point(1036, 21);
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
            this.panel3.Size = new System.Drawing.Size(1306, 44);
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
            this.panel8.Controls.Add(this.btnProximaQuestao);
            this.panel8.Controls.Add(this.panel2);
            this.panel8.Controls.Add(this.progressBar1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(243, 165);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1063, 459);
            this.panel8.TabIndex = 19;
            // 
            // pnlResultado
            // 
            this.pnlResultado.BackgroundImage = global::N2Quiz.Properties.Resources.erroufeioerrourude;
            this.pnlResultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlResultado.Location = new System.Drawing.Point(630, 100);
            this.pnlResultado.Name = "pnlResultado";
            this.pnlResultado.Size = new System.Drawing.Size(394, 350);
            this.pnlResultado.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 165);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(243, 459);
            this.panel6.TabIndex = 18;
            // 
            // FrmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1306, 624);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmQuiz_Activated);
            this.Shown += new System.EventHandler(this.FrmQuiz_Shown);
            this.panelPergunta.ResumeLayout(false);
            this.panelPergunta.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtbxQuestao;
        private System.Windows.Forms.Label lblNumeroQuestao;
        private System.Windows.Forms.Button btnAlternativaD;
        private System.Windows.Forms.Button btnAlternativaC;
        private System.Windows.Forms.Button btnAlternativaB;
        private System.Windows.Forms.Button btnAlternativaA;
        private System.Windows.Forms.Label lblAlternativaD;
        private System.Windows.Forms.Label lblAlternativaC;
        private System.Windows.Forms.Label lblAlternativaB;
        private System.Windows.Forms.Label lblAlternativaA;
        private System.Windows.Forms.Button btnProximaQuestao;
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
    }
}