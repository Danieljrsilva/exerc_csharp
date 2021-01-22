namespace calculadoraRadioECheck
{
    partial class frmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.grbOperações = new System.Windows.Forms.GroupBox();
            this.rdbRestoDiv = new System.Windows.Forms.RadioButton();
            this.rdbDivizao = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicacao = new System.Windows.Forms.RadioButton();
            this.rdbSubtracao = new System.Windows.Forms.RadioButton();
            this.rdbAdicicao = new System.Windows.Forms.RadioButton();
            this.grbAdicionais = new System.Windows.Forms.GroupBox();
            this.rdb20 = new System.Windows.Forms.RadioButton();
            this.rdb10 = new System.Windows.Forms.RadioButton();
            this.rdb15 = new System.Windows.Forms.RadioButton();
            this.rdb5 = new System.Windows.Forms.RadioButton();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtTotAcres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSairComMensagem = new System.Windows.Forms.Button();
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            this.lblRecebeHora = new System.Windows.Forms.Label();
            this.lblRecebeData = new System.Windows.Forms.Label();
            this.grbOperações.SuspendLayout();
            this.grbAdicionais.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbOperações
            // 
            this.grbOperações.BackColor = System.Drawing.Color.Transparent;
            this.grbOperações.Controls.Add(this.rdbRestoDiv);
            this.grbOperações.Controls.Add(this.rdbDivizao);
            this.grbOperações.Controls.Add(this.rdbMultiplicacao);
            this.grbOperações.Controls.Add(this.rdbSubtracao);
            this.grbOperações.Controls.Add(this.rdbAdicicao);
            this.grbOperações.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOperações.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbOperações.Location = new System.Drawing.Point(33, 184);
            this.grbOperações.Name = "grbOperações";
            this.grbOperações.Size = new System.Drawing.Size(312, 127);
            this.grbOperações.TabIndex = 0;
            this.grbOperações.TabStop = false;
            this.grbOperações.Text = "Operações";
            // 
            // rdbRestoDiv
            // 
            this.rdbRestoDiv.AutoSize = true;
            this.rdbRestoDiv.Location = new System.Drawing.Point(74, 94);
            this.rdbRestoDiv.Name = "rdbRestoDiv";
            this.rdbRestoDiv.Size = new System.Drawing.Size(163, 24);
            this.rdbRestoDiv.TabIndex = 5;
            this.rdbRestoDiv.TabStop = true;
            this.rdbRestoDiv.Text = "Resto da Divizão";
            this.rdbRestoDiv.UseVisualStyleBackColor = true;
            // 
            // rdbDivizao
            // 
            this.rdbDivizao.AutoSize = true;
            this.rdbDivizao.Location = new System.Drawing.Point(150, 60);
            this.rdbDivizao.Name = "rdbDivizao";
            this.rdbDivizao.Size = new System.Drawing.Size(85, 24);
            this.rdbDivizao.TabIndex = 4;
            this.rdbDivizao.TabStop = true;
            this.rdbDivizao.Text = "Divizão";
            this.rdbDivizao.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicacao
            // 
            this.rdbMultiplicacao.AutoSize = true;
            this.rdbMultiplicacao.Location = new System.Drawing.Point(6, 60);
            this.rdbMultiplicacao.Name = "rdbMultiplicacao";
            this.rdbMultiplicacao.Size = new System.Drawing.Size(131, 24);
            this.rdbMultiplicacao.TabIndex = 3;
            this.rdbMultiplicacao.TabStop = true;
            this.rdbMultiplicacao.Text = "Multiplicação";
            this.rdbMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rdbSubtracao
            // 
            this.rdbSubtracao.AutoSize = true;
            this.rdbSubtracao.Location = new System.Drawing.Point(150, 27);
            this.rdbSubtracao.Name = "rdbSubtracao";
            this.rdbSubtracao.Size = new System.Drawing.Size(110, 24);
            this.rdbSubtracao.TabIndex = 2;
            this.rdbSubtracao.TabStop = true;
            this.rdbSubtracao.Text = "Subtração";
            this.rdbSubtracao.UseVisualStyleBackColor = true;
            // 
            // rdbAdicicao
            // 
            this.rdbAdicicao.AutoSize = true;
            this.rdbAdicicao.Location = new System.Drawing.Point(6, 27);
            this.rdbAdicicao.Name = "rdbAdicicao";
            this.rdbAdicicao.Size = new System.Drawing.Size(82, 24);
            this.rdbAdicicao.TabIndex = 1;
            this.rdbAdicicao.TabStop = true;
            this.rdbAdicicao.Text = "Adição";
            this.rdbAdicicao.UseVisualStyleBackColor = true;
            // 
            // grbAdicionais
            // 
            this.grbAdicionais.BackColor = System.Drawing.Color.Transparent;
            this.grbAdicionais.Controls.Add(this.rdb20);
            this.grbAdicionais.Controls.Add(this.rdb10);
            this.grbAdicionais.Controls.Add(this.rdb15);
            this.grbAdicionais.Controls.Add(this.rdb5);
            this.grbAdicionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAdicionais.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbAdicionais.Location = new System.Drawing.Point(544, 184);
            this.grbAdicionais.Name = "grbAdicionais";
            this.grbAdicionais.Size = new System.Drawing.Size(327, 127);
            this.grbAdicionais.TabIndex = 1;
            this.grbAdicionais.TabStop = false;
            this.grbAdicionais.Text = "Adicionais";
            // 
            // rdb20
            // 
            this.rdb20.AutoSize = true;
            this.rdb20.Location = new System.Drawing.Point(148, 60);
            this.rdb20.Name = "rdb20";
            this.rdb20.Size = new System.Drawing.Size(62, 28);
            this.rdb20.TabIndex = 3;
            this.rdb20.TabStop = true;
            this.rdb20.Text = "+20";
            this.rdb20.UseVisualStyleBackColor = true;
            this.rdb20.CheckedChanged += new System.EventHandler(this.rdb20_CheckedChanged);
            // 
            // rdb10
            // 
            this.rdb10.AutoSize = true;
            this.rdb10.Location = new System.Drawing.Point(18, 60);
            this.rdb10.Name = "rdb10";
            this.rdb10.Size = new System.Drawing.Size(62, 28);
            this.rdb10.TabIndex = 2;
            this.rdb10.TabStop = true;
            this.rdb10.Text = "+10";
            this.rdb10.UseVisualStyleBackColor = true;
            this.rdb10.CheckedChanged += new System.EventHandler(this.rdb10_CheckedChanged);
            // 
            // rdb15
            // 
            this.rdb15.AutoSize = true;
            this.rdb15.Location = new System.Drawing.Point(148, 19);
            this.rdb15.Name = "rdb15";
            this.rdb15.Size = new System.Drawing.Size(62, 28);
            this.rdb15.TabIndex = 1;
            this.rdb15.TabStop = true;
            this.rdb15.Text = "+15";
            this.rdb15.UseVisualStyleBackColor = true;
            this.rdb15.CheckedChanged += new System.EventHandler(this.rdb15_CheckedChanged);
            // 
            // rdb5
            // 
            this.rdb5.AutoSize = true;
            this.rdb5.Location = new System.Drawing.Point(18, 19);
            this.rdb5.Name = "rdb5";
            this.rdb5.Size = new System.Drawing.Size(51, 28);
            this.rdb5.TabIndex = 0;
            this.rdb5.TabStop = true;
            this.rdb5.Text = "+5";
            this.rdb5.UseVisualStyleBackColor = true;
            this.rdb5.CheckedChanged += new System.EventHandler(this.rdb5_CheckedChanged);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(245, 350);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 2;
            // 
            // txtTotAcres
            // 
            this.txtTotAcres.Location = new System.Drawing.Point(771, 350);
            this.txtTotAcres.Name = "txtTotAcres";
            this.txtTotAcres.Size = new System.Drawing.Size(100, 20);
            this.txtTotAcres.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(37, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Resultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(548, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total com Acréscimo";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(245, 48);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 6;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(245, 121);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(30, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Digite o número 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(30, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Digite o número 2:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Black;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcular.Location = new System.Drawing.Point(570, 46);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(82, 45);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Location = new System.Drawing.Point(745, 46);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(126, 45);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
           
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Location = new System.Drawing.Point(570, 117);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(82, 43);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSairComMensagem
            // 
            this.btnSairComMensagem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSairComMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairComMensagem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSairComMensagem.Location = new System.Drawing.Point(745, 117);
            this.btnSairComMensagem.Name = "btnSairComMensagem";
            this.btnSairComMensagem.Size = new System.Drawing.Size(126, 43);
            this.btnSairComMensagem.TabIndex = 13;
            this.btnSairComMensagem.Text = "Sair com Mensagem";
            this.btnSairComMensagem.UseVisualStyleBackColor = false;
            // 
            // tmrHora
            // 
            this.tmrHora.Enabled = true;
            this.tmrHora.Interval = 1000;
            this.tmrHora.Tick += new System.EventHandler(this.tmrHora_Tick);
            // 
            // lblRecebeHora
            // 
            this.lblRecebeHora.AutoSize = true;
            this.lblRecebeHora.Location = new System.Drawing.Point(823, 20);
            this.lblRecebeHora.Name = "lblRecebeHora";
            this.lblRecebeHora.Size = new System.Drawing.Size(0, 13);
            this.lblRecebeHora.TabIndex = 14;
            // 
            // lblRecebeData
            // 
            this.lblRecebeData.AutoSize = true;
            this.lblRecebeData.Location = new System.Drawing.Point(589, 20);
            this.lblRecebeData.Name = "lblRecebeData";
            this.lblRecebeData.Size = new System.Drawing.Size(0, 13);
            this.lblRecebeData.TabIndex = 15;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(898, 395);
            this.Controls.Add(this.lblRecebeData);
            this.Controls.Add(this.lblRecebeHora);
            this.Controls.Add(this.btnSairComMensagem);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotAcres);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.grbAdicionais);
            this.Controls.Add(this.grbOperações);
            this.Name = "frmCalculadora";
            this.Text = "Calculadora Radio e Check";
            this.grbOperações.ResumeLayout(false);
            this.grbOperações.PerformLayout();
            this.grbAdicionais.ResumeLayout(false);
            this.grbAdicionais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbOperações;
        private System.Windows.Forms.GroupBox grbAdicionais;
        private System.Windows.Forms.RadioButton rdb20;
        private System.Windows.Forms.RadioButton rdb10;
        private System.Windows.Forms.RadioButton rdb15;
        private System.Windows.Forms.RadioButton rdb5;
        private System.Windows.Forms.RadioButton rdbRestoDiv;
        private System.Windows.Forms.RadioButton rdbDivizao;
        private System.Windows.Forms.RadioButton rdbMultiplicacao;
        private System.Windows.Forms.RadioButton rdbSubtracao;
        private System.Windows.Forms.RadioButton rdbAdicicao;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtTotAcres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSairComMensagem;
        private System.Windows.Forms.Timer tmrHora;
        private System.Windows.Forms.Label lblRecebeHora;
        private System.Windows.Forms.Label lblRecebeData;
    }
}

