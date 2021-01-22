namespace seteDaSorte
{
    partial class frmSeteDaSorte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeteDaSorte));
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNum3 = new System.Windows.Forms.Label();
            this.pcbImageJogo = new System.Windows.Forms.PictureBox();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.trmNum1 = new System.Windows.Forms.Timer(this.components);
            this.trmNum2 = new System.Windows.Forms.Timer(this.components);
            this.trmNum3 = new System.Windows.Forms.Timer(this.components);
            this.pgbSeteDaSorte = new System.Windows.Forms.ProgressBar();
            this.pgbSeteDaSorte2 = new System.Windows.Forms.ProgressBar();
            this.pgbSeteDaSorte3 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImageJogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.BackColor = System.Drawing.Color.Transparent;
            this.lblNum1.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(48, 52);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(0, 33);
            this.lblNum1.TabIndex = 0;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.BackColor = System.Drawing.Color.Transparent;
            this.lblNum2.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.Location = new System.Drawing.Point(266, 52);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(0, 33);
            this.lblNum2.TabIndex = 1;
            // 
            // lblNum3
            // 
            this.lblNum3.AutoSize = true;
            this.lblNum3.BackColor = System.Drawing.Color.Transparent;
            this.lblNum3.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum3.Location = new System.Drawing.Point(483, 52);
            this.lblNum3.Name = "lblNum3";
            this.lblNum3.Size = new System.Drawing.Size(0, 33);
            this.lblNum3.TabIndex = 2;
            // 
            // pcbImageJogo
            // 
            this.pcbImageJogo.BackgroundImage = global::seteDaSorte.Properties.Resources.download__6_;
            this.pcbImageJogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbImageJogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbImageJogo.Image = global::seteDaSorte.Properties.Resources.download__6_;
            this.pcbImageJogo.InitialImage = null;
            this.pcbImageJogo.Location = new System.Drawing.Point(85, 126);
            this.pcbImageJogo.Name = "pcbImageJogo";
            this.pcbImageJogo.Size = new System.Drawing.Size(413, 157);
            this.pcbImageJogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImageJogo.TabIndex = 3;
            this.pcbImageJogo.TabStop = false;
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.Transparent;
            this.btnJogar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.ForeColor = System.Drawing.Color.Black;
            this.btnJogar.Location = new System.Drawing.Point(54, 315);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(97, 36);
            this.btnJogar.TabIndex = 4;
            this.btnJogar.Text = "&Jogar";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Location = new System.Drawing.Point(442, 315);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(109, 36);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Enabled = false;
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.ForeColor = System.Drawing.Color.Black;
            this.btnReiniciar.Location = new System.Drawing.Point(229, 315);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(114, 36);
            this.btnReiniciar.TabIndex = 6;
            this.btnReiniciar.Text = "&Reiniciar Jogo";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            // 
            // trmNum1
            // 
            this.trmNum1.Interval = 500;
            this.trmNum1.Tick += new System.EventHandler(this.trmNum1_Tick);
            // 
            // trmNum2
            // 
            this.trmNum2.Interval = 500;
            this.trmNum2.Tick += new System.EventHandler(this.trmNum2_Tick);
            // 
            // trmNum3
            // 
            this.trmNum3.Interval = 500;
            this.trmNum3.Tick += new System.EventHandler(this.trmNum3_Tick);
            // 
            // pgbSeteDaSorte
            // 
            this.pgbSeteDaSorte.Location = new System.Drawing.Point(12, 369);
            this.pgbSeteDaSorte.Name = "pgbSeteDaSorte";
            this.pgbSeteDaSorte.Size = new System.Drawing.Size(573, 32);
            this.pgbSeteDaSorte.TabIndex = 7;
            // 
            // pgbSeteDaSorte2
            // 
            this.pgbSeteDaSorte2.Location = new System.Drawing.Point(12, 407);
            this.pgbSeteDaSorte2.Name = "pgbSeteDaSorte2";
            this.pgbSeteDaSorte2.Size = new System.Drawing.Size(573, 31);
            this.pgbSeteDaSorte2.TabIndex = 8;
            // 
            // pgbSeteDaSorte3
            // 
            this.pgbSeteDaSorte3.Location = new System.Drawing.Point(12, 444);
            this.pgbSeteDaSorte3.Name = "pgbSeteDaSorte3";
            this.pgbSeteDaSorte3.Size = new System.Drawing.Size(573, 32);
            this.pgbSeteDaSorte3.TabIndex = 9;
            // 
            // frmSeteDaSorte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(597, 492);
            this.Controls.Add(this.pgbSeteDaSorte3);
            this.Controls.Add(this.pgbSeteDaSorte2);
            this.Controls.Add(this.pgbSeteDaSorte);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.pcbImageJogo);
            this.Controls.Add(this.lblNum3);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmSeteDaSorte";
            this.Text = "Sete da sorte";
            ((System.ComponentModel.ISupportInitialize)(this.pcbImageJogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblNum3;
        private System.Windows.Forms.PictureBox pcbImageJogo;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Timer trmNum1;
        private System.Windows.Forms.Timer trmNum2;
        private System.Windows.Forms.Timer trmNum3;
        private System.Windows.Forms.ProgressBar pgbSeteDaSorte;
        private System.Windows.Forms.ProgressBar pgbSeteDaSorte2;
        private System.Windows.Forms.ProgressBar pgbSeteDaSorte3;
    }
}

