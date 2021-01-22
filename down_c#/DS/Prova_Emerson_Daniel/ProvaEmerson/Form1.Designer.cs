namespace ProvaEmerson
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.rdbSim = new System.Windows.Forms.RadioButton();
            this.rdbNão = new System.Windows.Forms.RadioButton();
            this.lblTela = new System.Windows.Forms.Label();
            this.btnPróximaTela = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(98, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "&Digite seu nome -->";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(141, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // rdbSim
            // 
            this.rdbSim.AutoSize = true;
            this.rdbSim.Location = new System.Drawing.Point(218, 70);
            this.rdbSim.Name = "rdbSim";
            this.rdbSim.Size = new System.Drawing.Size(42, 17);
            this.rdbSim.TabIndex = 2;
            this.rdbSim.TabStop = true;
            this.rdbSim.Text = "&Sim";
            this.rdbSim.UseVisualStyleBackColor = true;
            // 
            // rdbNão
            // 
            this.rdbNão.AutoSize = true;
            this.rdbNão.Location = new System.Drawing.Point(167, 70);
            this.rdbNão.Name = "rdbNão";
            this.rdbNão.Size = new System.Drawing.Size(45, 17);
            this.rdbNão.TabIndex = 3;
            this.rdbNão.TabStop = true;
            this.rdbNão.Text = "Não";
            this.rdbNão.UseVisualStyleBackColor = true;
            this.rdbNão.CheckedChanged += new System.EventHandler(this.rdbNão_CheckedChanged);
            // 
            // lblTela
            // 
            this.lblTela.AutoSize = true;
            this.lblTela.Location = new System.Drawing.Point(12, 70);
            this.lblTela.Name = "lblTela";
            this.lblTela.Size = new System.Drawing.Size(149, 13);
            this.lblTela.TabIndex = 4;
            this.lblTela.Text = "&Deseja ir para a próxima tela ?";
            // 
            // btnPróximaTela
            // 
            this.btnPróximaTela.Location = new System.Drawing.Point(97, 125);
            this.btnPróximaTela.Name = "btnPróximaTela";
            this.btnPróximaTela.Size = new System.Drawing.Size(130, 23);
            this.btnPróximaTela.TabIndex = 6;
            this.btnPróximaTela.Text = "&Ir para a próxima tela ?";
            this.btnPróximaTela.UseVisualStyleBackColor = true;
            this.btnPróximaTela.Click += new System.EventHandler(this.btnPróximaTela_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(565, 375);
            this.Controls.Add(this.btnPróximaTela);
            this.Controls.Add(this.lblTela);
            this.Controls.Add(this.rdbNão);
            this.Controls.Add(this.rdbSim);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Primeira Tela";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RadioButton rdbSim;
        private System.Windows.Forms.RadioButton rdbNão;
        private System.Windows.Forms.Label lblTela;
        private System.Windows.Forms.Button btnPróximaTela;
    }
}

