namespace ProvaEmerson
{
    partial class Segunda_Tela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Segunda_Tela));
            this.txtRecebeNome = new System.Windows.Forms.TextBox();
            this.lblSeuNome = new System.Windows.Forms.Label();
            this.cmbIdade = new System.Windows.Forms.ComboBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.ckbEsportes = new System.Windows.Forms.CheckBox();
            this.ckbMúsica = new System.Windows.Forms.CheckBox();
            this.ckbLeitura = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbViagem = new System.Windows.Forms.CheckBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.btnProcessarDados = new System.Windows.Forms.Button();
            this.lblRecebeNome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblpreferencias = new System.Windows.Forms.Label();
            this.lblrecebeIdade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRecebeNome
            // 
            this.txtRecebeNome.Location = new System.Drawing.Point(141, 25);
            this.txtRecebeNome.Name = "txtRecebeNome";
            this.txtRecebeNome.Size = new System.Drawing.Size(100, 20);
            this.txtRecebeNome.TabIndex = 2;
            this.txtRecebeNome.TextChanged += new System.EventHandler(this.txtRecebeNome_TextChanged);
            // 
            // lblSeuNome
            // 
            this.lblSeuNome.AutoSize = true;
            this.lblSeuNome.Location = new System.Drawing.Point(18, 28);
            this.lblSeuNome.Name = "lblSeuNome";
            this.lblSeuNome.Size = new System.Drawing.Size(72, 13);
            this.lblSeuNome.TabIndex = 3;
            this.lblSeuNome.Text = "&Seu Nome -->";
            // 
            // cmbIdade
            // 
            this.cmbIdade.FormattingEnabled = true;
            this.cmbIdade.Items.AddRange(new object[] {
            "1\t",
            "2\t\t",
            "3\t\t",
            "4\t",
            "5\t\t",
            "6\t\t",
            "7\t\t",
            "8\t\t",
            "9\t\t",
            "10\t\t",
            "11\t",
            "12\t\t",
            "13\t\t",
            "14\t\t",
            "15\tquinze\t",
            "16\tdezasseis\t",
            "17\tdezassete\t",
            "18\tdezoito\t",
            "19\tdezanove\t",
            "20\tvinte\t",
            "21\tvinte e um\t",
            "22\tvinte e dois\t",
            "23\tvinte e três\t",
            "24\tvinte e quatro\t",
            "25\tvinte e cinco\t",
            "26\tvinte e seis\t",
            "27\tvinte e sete\t",
            "28\tvinte e oito\t",
            "29\tvinte e nove\t",
            "30\ttrinta\t",
            "31\ttrinta e um\t",
            "32\ttrinta e dois\t",
            "33\ttrinta e três\t",
            "34\ttrinta e quatro\t",
            "35\ttrinta e cinco\t",
            "36\ttrinta e seis\t",
            "37\ttrinta e sete\t",
            "38\ttrinta e oito\t",
            "39\ttrinta e nove\t",
            "40\tquarenta\t",
            "41\tquarenta e um\t",
            "42\tquarenta e dois\t",
            "43\tquarenta e três\t",
            "44\tquarenta e quatro\t",
            "45\tquarenta e cinco\t",
            "46\tquarenta e seis\t",
            "47\tquarenta e sete\t",
            "48\tquarenta e oito\t",
            "49\tquarenta e nove\t",
            "50\tcinquenta\t",
            "51\tcinquenta e um\t",
            "52\tcinquenta e dois\t",
            "53\tcinquenta e três\t",
            "54\tcinquenta e quatro\t",
            "55\tcinquenta e cinco\t",
            "56\tcinquenta e seis\t",
            "57\tcinquenta e sete\t",
            "58\tcinquenta e oito\t",
            "59\tcinquenta e nove\t",
            "60\tsessenta\t",
            "61\tsessenta e um\t",
            "62\tsessenta e dois\t",
            "63\tsessenta e três\t",
            "64\tsessenta e quatro\t",
            "65\tsessenta e cinco\t",
            "66\tsessenta e seis\t",
            "67\tsessenta e sete\t",
            "68\tsessenta e oito\t",
            "69\tsessenta e nove\t",
            "70\tsetenta\t",
            "71\tsetenta e um\t",
            "72\tsetenta e dois\t",
            "73\tsetenta e três\t",
            "74\tsetenta e quatro\t",
            "75\tsetenta e cinco\t",
            "76\tsetenta e seis\t",
            "77\tsetenta e sete\t",
            "78\tsetenta e oito\t",
            "79\tsetenta e nove\t",
            "80\toitenta\t",
            "81\toitenta e um\t",
            "82\toitenta e dois\t",
            "83\toitenta e três\t",
            "84\toitenta e quatro\t",
            "85\toitenta e cinco",
            "86\toitenta e seis",
            "87\toitenta e sete\t",
            "88\toitenta e oito\t",
            "89\toitenta e nove\t",
            "90\tnoventa\t",
            "91\tnoventa e um\t",
            "92\tnoventa e dois\t",
            "93\tnoventa e três\t",
            "94\tnoventa e quatro",
            "95\tnoventa e cinco\t",
            "96\tnoventa e seis\t",
            "97\tnoventa e sete\t",
            "98\tnoventa e oito\t",
            "99\tnoventa e nove\t",
            "100\tcem"});
            this.cmbIdade.Location = new System.Drawing.Point(470, 25);
            this.cmbIdade.Name = "cmbIdade";
            this.cmbIdade.Size = new System.Drawing.Size(121, 21);
            this.cmbIdade.TabIndex = 4;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(316, 28);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(118, 13);
            this.lblIdade.TabIndex = 5;
            this.lblIdade.Text = "&Selecione sua idade -->";
            // 
            // ckbEsportes
            // 
            this.ckbEsportes.AutoSize = true;
            this.ckbEsportes.Location = new System.Drawing.Point(173, 94);
            this.ckbEsportes.Name = "ckbEsportes";
            this.ckbEsportes.Size = new System.Drawing.Size(84, 17);
            this.ckbEsportes.TabIndex = 6;
            this.ckbEsportes.Text = "&ESPORTES";
            this.ckbEsportes.UseVisualStyleBackColor = true;
            // 
            // ckbMúsica
            // 
            this.ckbMúsica.AutoSize = true;
            this.ckbMúsica.Location = new System.Drawing.Point(281, 95);
            this.ckbMúsica.Name = "ckbMúsica";
            this.ckbMúsica.Size = new System.Drawing.Size(67, 17);
            this.ckbMúsica.TabIndex = 7;
            this.ckbMúsica.Text = "&MÚSICA";
            this.ckbMúsica.UseVisualStyleBackColor = true;
            this.ckbMúsica.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // ckbLeitura
            // 
            this.ckbLeitura.AutoSize = true;
            this.ckbLeitura.Location = new System.Drawing.Point(377, 95);
            this.ckbLeitura.Name = "ckbLeitura";
            this.ckbLeitura.Size = new System.Drawing.Size(72, 17);
            this.ckbLeitura.TabIndex = 8;
            this.ckbLeitura.Text = "&LEITURA";
            this.ckbLeitura.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "&Selecione suas preferências -->";
            // 
            // ckbViagem
            // 
            this.ckbViagem.AutoSize = true;
            this.ckbViagem.Location = new System.Drawing.Point(487, 94);
            this.ckbViagem.Name = "ckbViagem";
            this.ckbViagem.Size = new System.Drawing.Size(67, 17);
            this.ckbViagem.TabIndex = 10;
            this.ckbViagem.Text = "&VIAGEM";
            this.ckbViagem.UseVisualStyleBackColor = true;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 166);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 13);
            this.lbl1.TabIndex = 12;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(12, 188);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(0, 13);
            this.lbl2.TabIndex = 13;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(12, 210);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(0, 13);
            this.lbl3.TabIndex = 14;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(12, 233);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(0, 13);
            this.lbl4.TabIndex = 15;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(12, 255);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(0, 13);
            this.lbl5.TabIndex = 16;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(12, 288);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(0, 13);
            this.lbl6.TabIndex = 17;
            // 
            // btnProcessarDados
            // 
            this.btnProcessarDados.Location = new System.Drawing.Point(173, 141);
            this.btnProcessarDados.Name = "btnProcessarDados";
            this.btnProcessarDados.Size = new System.Drawing.Size(140, 23);
            this.btnProcessarDados.TabIndex = 18;
            this.btnProcessarDados.Text = "&Processar Dados";
            this.btnProcessarDados.UseVisualStyleBackColor = true;
            this.btnProcessarDados.Click += new System.EventHandler(this.btnProcessarDados_Click);
            // 
            // lblRecebeNome
            // 
            this.lblRecebeNome.AutoSize = true;
            this.lblRecebeNome.Location = new System.Drawing.Point(18, 219);
            this.lblRecebeNome.Name = "lblRecebeNome";
            this.lblRecebeNome.Size = new System.Drawing.Size(33, 13);
            this.lblRecebeNome.TabIndex = 19;
            this.lblRecebeNome.Text = "nome";
            this.lblRecebeNome.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // lblpreferencias
            // 
            this.lblpreferencias.AutoSize = true;
            this.lblpreferencias.Location = new System.Drawing.Point(18, 265);
            this.lblpreferencias.Name = "lblpreferencias";
            this.lblpreferencias.Size = new System.Drawing.Size(65, 13);
            this.lblpreferencias.TabIndex = 22;
            this.lblpreferencias.Text = "preferencias";
            this.lblpreferencias.Visible = false;
            // 
            // lblrecebeIdade
            // 
            this.lblrecebeIdade.AutoSize = true;
            this.lblrecebeIdade.Location = new System.Drawing.Point(18, 242);
            this.lblrecebeIdade.Name = "lblrecebeIdade";
            this.lblrecebeIdade.Size = new System.Drawing.Size(33, 13);
            this.lblrecebeIdade.TabIndex = 23;
            this.lblrecebeIdade.Text = "idade";
            this.lblrecebeIdade.Visible = false;
            // 
            // Segunda_Tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(641, 406);
            this.Controls.Add(this.lblrecebeIdade);
            this.Controls.Add(this.lblpreferencias);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRecebeNome);
            this.Controls.Add(this.btnProcessarDados);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.ckbViagem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckbLeitura);
            this.Controls.Add(this.ckbMúsica);
            this.Controls.Add(this.ckbEsportes);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.cmbIdade);
            this.Controls.Add(this.lblSeuNome);
            this.Controls.Add(this.txtRecebeNome);
            this.Name = "Segunda_Tela";
            this.Text = "Segunda_Tela";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecebeNome;
        private System.Windows.Forms.Label lblSeuNome;
        private System.Windows.Forms.ComboBox cmbIdade;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.CheckBox ckbEsportes;
        private System.Windows.Forms.CheckBox ckbMúsica;
        private System.Windows.Forms.CheckBox ckbLeitura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbViagem;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Button btnProcessarDados;
        private System.Windows.Forms.Label lblRecebeNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblpreferencias;
        private System.Windows.Forms.Label lblrecebeIdade;
    }
}