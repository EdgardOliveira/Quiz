namespace N2Quiz
{
    partial class FrmJogador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJogador));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblRanking = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDados = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRegistrarJogar = new System.Windows.Forms.Button();
            this.txtbxNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblRanking);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 121);
            this.panel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(300, 21);
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
            this.lblRanking.Size = new System.Drawing.Size(298, 78);
            this.lblRanking.TabIndex = 4;
            this.lblRanking.Text = "Jogador";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.lblDados);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 44);
            this.panel2.TabIndex = 9;
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDados.ForeColor = System.Drawing.Color.White;
            this.lblDados.Location = new System.Drawing.Point(199, 0);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(162, 39);
            this.lblDados.TabIndex = 5;
            this.lblDados.Text = "Cadastro";
            this.lblDados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRegistrarJogar);
            this.panel3.Controls.Add(this.txtbxNome);
            this.panel3.Controls.Add(this.lblNome);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(570, 130);
            this.panel3.TabIndex = 10;
            // 
            // btnRegistrarJogar
            // 
            this.btnRegistrarJogar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarJogar.Location = new System.Drawing.Point(358, 84);
            this.btnRegistrarJogar.Name = "btnRegistrarJogar";
            this.btnRegistrarJogar.Size = new System.Drawing.Size(200, 34);
            this.btnRegistrarJogar.TabIndex = 5;
            this.btnRegistrarJogar.Text = "Registrar e Jogar";
            this.btnRegistrarJogar.UseVisualStyleBackColor = true;
            this.btnRegistrarJogar.Click += new System.EventHandler(this.btnRegistrarJogar_Click);
            // 
            // txtbxNome
            // 
            this.txtbxNome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNome.Location = new System.Drawing.Point(48, 43);
            this.txtbxNome.MaxLength = 22;
            this.txtbxNome.Name = "txtbxNome";
            this.txtbxNome.Size = new System.Drawing.Size(464, 29);
            this.txtbxNome.TabIndex = 4;
            this.txtbxNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxNome_KeyPress);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(44, 18);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(70, 22);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // FrmJogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 295);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmJogador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informe o nome do jogador";
            this.Shown += new System.EventHandler(this.FrmJogador_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRanking;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRegistrarJogar;
        private System.Windows.Forms.TextBox txtbxNome;
        private System.Windows.Forms.Label lblNome;
    }
}