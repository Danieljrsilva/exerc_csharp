namespace email
{
    partial class frmEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmail));
            this.txtPara = new System.Windows.Forms.TextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.txtAnexo = new System.Windows.Forms.TextBox();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAnexo = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ofdAnexo = new System.Windows.Forms.OpenFileDialog();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.cmbTipoemail = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(440, 28);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(267, 20);
            this.txtPara.TabIndex = 0;
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(89, 173);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(618, 20);
            this.txtAssunto.TabIndex = 1;
            // 
            // txtAnexo
            // 
            this.txtAnexo.Location = new System.Drawing.Point(89, 199);
            this.txtAnexo.Name = "txtAnexo";
            this.txtAnexo.Size = new System.Drawing.Size(618, 20);
            this.txtAnexo.TabIndex = 2;
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(12, 254);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(695, 131);
            this.txtMensagem.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Para";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Assunto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Anexo";
            // 
            // btnAnexo
            // 
            this.btnAnexo.Location = new System.Drawing.Point(632, 225);
            this.btnAnexo.Name = "btnAnexo";
            this.btnAnexo.Size = new System.Drawing.Size(75, 23);
            this.btnAnexo.TabIndex = 7;
            this.btnAnexo.Text = "&Anexar";
            this.btnAnexo.UseVisualStyleBackColor = true;
            this.btnAnexo.Click += new System.EventHandler(this.btnAnexo_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(632, 391);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "&Enviar Email";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mensagem";
            // 
            // ofdAnexo
            // 
            this.ofdAnexo.FileName = "openFileDialog1";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(112, 118);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '#';
            this.txtSenha.Size = new System.Drawing.Size(139, 20);
            this.txtSenha.TabIndex = 10;
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(89, 28);
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(265, 20);
            this.txtDe.TabIndex = 11;
            // 
            // cmbTipoemail
            // 
            this.cmbTipoemail.FormattingEnabled = true;
            this.cmbTipoemail.Items.AddRange(new object[] {
            "@etec.sp.gov.br",
            "@hotmail.com",
            "@gmail.com",
            "@yahoo.com.br",
            "@outlook.com.br"});
            this.cmbTipoemail.Location = new System.Drawing.Point(130, 79);
            this.cmbTipoemail.Name = "cmbTipoemail";
            this.cmbTipoemail.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoemail.TabIndex = 12;
            this.cmbTipoemail.SelectedIndexChanged += new System.EventHandler(this.cmbTipoemail_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "De";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Confirme seu e-mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Senha";
            // 
            // frmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(719, 444);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTipoemail);
            this.Controls.Add(this.txtDe);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnAnexo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.txtAnexo);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.txtPara);
            this.Name = "frmEmail";
            this.Text = "frmEmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.TextBox txtAnexo;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAnexo;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog ofdAnexo;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.ComboBox cmbTipoemail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

