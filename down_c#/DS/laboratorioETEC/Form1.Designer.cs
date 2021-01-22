namespace laboratorioETEC
{
    partial class frmLabETEC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLabETEC));
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtValorAPagar = new System.Windows.Forms.TextBox();
            this.txtValorRecebido = new System.Windows.Forms.TextBox();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grbExames = new System.Windows.Forms.GroupBox();
            this.ckbProto = new System.Windows.Forms.CheckBox();
            this.ckbCopro = new System.Windows.Forms.CheckBox();
            this.ckbAcidoUrico = new System.Windows.Forms.CheckBox();
            this.ckbUreia = new System.Windows.Forms.CheckBox();
            this.ckbGlicose = new System.Windows.Forms.CheckBox();
            this.ckbTSH = new System.Windows.Forms.CheckBox();
            this.ckbColesterol = new System.Windows.Forms.CheckBox();
            this.ckbUrina = new System.Windows.Forms.CheckBox();
            this.ckbHemograma = new System.Windows.Forms.CheckBox();
            this.grbConvenio = new System.Windows.Forms.GroupBox();
            this.rdbNao = new System.Windows.Forms.RadioButton();
            this.rdbSim = new System.Windows.Forms.RadioButton();
            this.grbValores = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnConfirmaDados = new System.Windows.Forms.Button();
            this.grbExames.SuspendLayout();
            this.grbConvenio.SuspendLayout();
            this.grbValores.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Location = new System.Drawing.Point(238, 25);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(286, 20);
            this.txtNomePaciente.TabIndex = 0;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(299, 70);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 1;
            // 
            // txtValorAPagar
            // 
            this.txtValorAPagar.Location = new System.Drawing.Point(157, 23);
            this.txtValorAPagar.Name = "txtValorAPagar";
            this.txtValorAPagar.ReadOnly = true;
            this.txtValorAPagar.Size = new System.Drawing.Size(100, 20);
            this.txtValorAPagar.TabIndex = 2;
            // 
            // txtValorRecebido
            // 
            this.txtValorRecebido.Location = new System.Drawing.Point(157, 66);
            this.txtValorRecebido.Name = "txtValorRecebido";
            this.txtValorRecebido.Size = new System.Drawing.Size(100, 20);
            this.txtValorRecebido.TabIndex = 3;
            this.txtValorRecebido.TextChanged += new System.EventHandler(this.txtValorRecebido_TextChanged);
            // 
            // txtTroco
            // 
            this.txtTroco.Location = new System.Drawing.Point(157, 104);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ReadOnly = true;
            this.txtTroco.Size = new System.Drawing.Size(100, 20);
            this.txtTroco.TabIndex = 4;
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbSexo.Location = new System.Drawing.Point(278, 105);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(121, 21);
            this.cmbSexo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome do Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Idade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor a Pagar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor Recebido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Troco";
            // 
            // grbExames
            // 
            this.grbExames.Controls.Add(this.ckbProto);
            this.grbExames.Controls.Add(this.ckbCopro);
            this.grbExames.Controls.Add(this.ckbAcidoUrico);
            this.grbExames.Controls.Add(this.ckbUreia);
            this.grbExames.Controls.Add(this.ckbGlicose);
            this.grbExames.Controls.Add(this.ckbTSH);
            this.grbExames.Controls.Add(this.ckbColesterol);
            this.grbExames.Controls.Add(this.ckbUrina);
            this.grbExames.Controls.Add(this.ckbHemograma);
            this.grbExames.Location = new System.Drawing.Point(24, 157);
            this.grbExames.Name = "grbExames";
            this.grbExames.Size = new System.Drawing.Size(315, 100);
            this.grbExames.TabIndex = 12;
            this.grbExames.TabStop = false;
            this.grbExames.Text = "Exames (cada R$ 50,00)";
            this.grbExames.Visible = false;
            // 
            // ckbProto
            // 
            this.ckbProto.AutoSize = true;
            this.ckbProto.Location = new System.Drawing.Point(194, 83);
            this.ckbProto.Name = "ckbProto";
            this.ckbProto.Size = new System.Drawing.Size(116, 17);
            this.ckbProto.TabIndex = 8;
            this.ckbProto.Text = "Protoparasitológico";
            this.ckbProto.UseVisualStyleBackColor = true;
            // 
            // ckbCopro
            // 
            this.ckbCopro.AutoSize = true;
            this.ckbCopro.Location = new System.Drawing.Point(194, 56);
            this.ckbCopro.Name = "ckbCopro";
            this.ckbCopro.Size = new System.Drawing.Size(86, 17);
            this.ckbCopro.TabIndex = 7;
            this.ckbCopro.Text = "Coprocultura";
            this.ckbCopro.UseVisualStyleBackColor = true;
            // 
            // ckbAcidoUrico
            // 
            this.ckbAcidoUrico.AutoSize = true;
            this.ckbAcidoUrico.Location = new System.Drawing.Point(194, 24);
            this.ckbAcidoUrico.Name = "ckbAcidoUrico";
            this.ckbAcidoUrico.Size = new System.Drawing.Size(81, 17);
            this.ckbAcidoUrico.TabIndex = 6;
            this.ckbAcidoUrico.Text = "Ácido Úrico";
            this.ckbAcidoUrico.UseVisualStyleBackColor = true;
            // 
            // ckbUreia
            // 
            this.ckbUreia.AutoSize = true;
            this.ckbUreia.Location = new System.Drawing.Point(89, 24);
            this.ckbUreia.Name = "ckbUreia";
            this.ckbUreia.Size = new System.Drawing.Size(102, 17);
            this.ckbUreia.TabIndex = 5;
            this.ckbUreia.Text = "Ureia e Creatina";
            this.ckbUreia.UseVisualStyleBackColor = true;
            // 
            // ckbGlicose
            // 
            this.ckbGlicose.AutoSize = true;
            this.ckbGlicose.Location = new System.Drawing.Point(89, 56);
            this.ckbGlicose.Name = "ckbGlicose";
            this.ckbGlicose.Size = new System.Drawing.Size(61, 17);
            this.ckbGlicose.TabIndex = 4;
            this.ckbGlicose.Text = "Glicose";
            this.ckbGlicose.UseVisualStyleBackColor = true;
            // 
            // ckbTSH
            // 
            this.ckbTSH.AutoSize = true;
            this.ckbTSH.Location = new System.Drawing.Point(89, 83);
            this.ckbTSH.Name = "ckbTSH";
            this.ckbTSH.Size = new System.Drawing.Size(95, 17);
            this.ckbTSH.TabIndex = 3;
            this.ckbTSH.Text = "TSH e T4 livre";
            this.ckbTSH.UseVisualStyleBackColor = true;
            // 
            // ckbColesterol
            // 
            this.ckbColesterol.AutoSize = true;
            this.ckbColesterol.Location = new System.Drawing.Point(3, 83);
            this.ckbColesterol.Name = "ckbColesterol";
            this.ckbColesterol.Size = new System.Drawing.Size(72, 17);
            this.ckbColesterol.TabIndex = 2;
            this.ckbColesterol.Text = "Colesterol";
            this.ckbColesterol.UseVisualStyleBackColor = true;
            // 
            // ckbUrina
            // 
            this.ckbUrina.AutoSize = true;
            this.ckbUrina.Location = new System.Drawing.Point(3, 56);
            this.ckbUrina.Name = "ckbUrina";
            this.ckbUrina.Size = new System.Drawing.Size(60, 17);
            this.ckbUrina.TabIndex = 1;
            this.ckbUrina.Text = "Urina 1";
            this.ckbUrina.UseVisualStyleBackColor = true;
            // 
            // ckbHemograma
            // 
            this.ckbHemograma.AutoSize = true;
            this.ckbHemograma.Location = new System.Drawing.Point(3, 24);
            this.ckbHemograma.Name = "ckbHemograma";
            this.ckbHemograma.Size = new System.Drawing.Size(83, 17);
            this.ckbHemograma.TabIndex = 0;
            this.ckbHemograma.Text = "Hemograma";
            this.ckbHemograma.UseVisualStyleBackColor = true;
            // 
            // grbConvenio
            // 
            this.grbConvenio.Controls.Add(this.rdbNao);
            this.grbConvenio.Controls.Add(this.rdbSim);
            this.grbConvenio.Location = new System.Drawing.Point(438, 157);
            this.grbConvenio.Name = "grbConvenio";
            this.grbConvenio.Size = new System.Drawing.Size(310, 100);
            this.grbConvenio.TabIndex = 0;
            this.grbConvenio.TabStop = false;
            this.grbConvenio.Text = "Convênio";
            this.grbConvenio.Visible = false;
            this.grbConvenio.Enter += new System.EventHandler(this.grbConvenio_Enter);
            // 
            // rdbNao
            // 
            this.rdbNao.AutoSize = true;
            this.rdbNao.Location = new System.Drawing.Point(21, 67);
            this.rdbNao.Name = "rdbNao";
            this.rdbNao.Size = new System.Drawing.Size(45, 17);
            this.rdbNao.TabIndex = 1;
            this.rdbNao.TabStop = true;
            this.rdbNao.Text = "Não";
            this.rdbNao.UseVisualStyleBackColor = true;
            // 
            // rdbSim
            // 
            this.rdbSim.AutoSize = true;
            this.rdbSim.Location = new System.Drawing.Point(21, 24);
            this.rdbSim.Name = "rdbSim";
            this.rdbSim.Size = new System.Drawing.Size(133, 17);
            this.rdbSim.TabIndex = 0;
            this.rdbSim.TabStop = true;
            this.rdbSim.Text = "Sim (20% de desconto)";
            this.rdbSim.UseVisualStyleBackColor = true;
            // 
            // grbValores
            // 
            this.grbValores.Controls.Add(this.label4);
            this.grbValores.Controls.Add(this.txtValorAPagar);
            this.grbValores.Controls.Add(this.txtValorRecebido);
            this.grbValores.Controls.Add(this.label6);
            this.grbValores.Controls.Add(this.txtTroco);
            this.grbValores.Controls.Add(this.label5);
            this.grbValores.Location = new System.Drawing.Point(24, 274);
            this.grbValores.Name = "grbValores";
            this.grbValores.Size = new System.Drawing.Size(422, 138);
            this.grbValores.TabIndex = 0;
            this.grbValores.TabStop = false;
            this.grbValores.Text = "Valores";
            this.grbValores.Visible = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(517, 286);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(517, 374);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
       
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(517, 331);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            
            // 
            // btnConfirmaDados
            // 
            this.btnConfirmaDados.Location = new System.Drawing.Point(414, 68);
            this.btnConfirmaDados.Name = "btnConfirmaDados";
            this.btnConfirmaDados.Size = new System.Drawing.Size(110, 23);
            this.btnConfirmaDados.TabIndex = 13;
            this.btnConfirmaDados.Text = "C&onfirma Dados";
            this.btnConfirmaDados.UseVisualStyleBackColor = true;
            this.btnConfirmaDados.Click += new System.EventHandler(this.btnConfirmaDados_Click);
            // 
            // frmLabETEC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(760, 485);
            this.Controls.Add(this.btnConfirmaDados);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.grbConvenio);
            this.Controls.Add(this.grbValores);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grbExames);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtNomePaciente);
            this.Name = "frmLabETEC";
            this.Text = "Lab ETEC 3.0";
            this.Load += new System.EventHandler(this.frmLabETEC_Load);
            this.grbExames.ResumeLayout(false);
            this.grbExames.PerformLayout();
            this.grbConvenio.ResumeLayout(false);
            this.grbConvenio.PerformLayout();
            this.grbValores.ResumeLayout(false);
            this.grbValores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtValorAPagar;
        private System.Windows.Forms.TextBox txtValorRecebido;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grbExames;
        private System.Windows.Forms.CheckBox ckbProto;
        private System.Windows.Forms.CheckBox ckbCopro;
        private System.Windows.Forms.CheckBox ckbAcidoUrico;
        private System.Windows.Forms.CheckBox ckbUreia;
        private System.Windows.Forms.CheckBox ckbGlicose;
        private System.Windows.Forms.CheckBox ckbTSH;
        private System.Windows.Forms.CheckBox ckbColesterol;
        private System.Windows.Forms.CheckBox ckbUrina;
        private System.Windows.Forms.CheckBox ckbHemograma;
        private System.Windows.Forms.GroupBox grbConvenio;
        private System.Windows.Forms.RadioButton rdbNao;
        private System.Windows.Forms.RadioButton rdbSim;
        private System.Windows.Forms.GroupBox grbValores;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConfirmaDados;
    }
}

