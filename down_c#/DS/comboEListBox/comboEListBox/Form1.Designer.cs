namespace comboEListBox
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
            this.lstRecebeValorCombo = new System.Windows.Forms.ListBox();
            this.lstRecebeEstadoDigitado = new System.Windows.Forms.ListBox();
            this.cmbAddViaPropriedade = new System.Windows.Forms.ComboBox();
            this.cmbAddViaCod = new System.Windows.Forms.ComboBox();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtRecebeValorCombo = new System.Windows.Forms.TextBox();
            this.txtRecebeValorSemIf = new System.Windows.Forms.TextBox();
            this.txtRecebeValorList = new System.Windows.Forms.TextBox();
            this.cmbRecebeEstado = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOrdem = new System.Windows.Forms.Button();
            this.btnRemoveCombo = new System.Windows.Forms.Button();
            this.btnRemovedoList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstRecebeValorCombo
            // 
            this.lstRecebeValorCombo.FormattingEnabled = true;
            this.lstRecebeValorCombo.Location = new System.Drawing.Point(38, 370);
            this.lstRecebeValorCombo.Name = "lstRecebeValorCombo";
            this.lstRecebeValorCombo.Size = new System.Drawing.Size(120, 95);
            this.lstRecebeValorCombo.Sorted = true;
            this.lstRecebeValorCombo.TabIndex = 0;
            this.lstRecebeValorCombo.SelectedIndexChanged += new System.EventHandler(this.lstRecebeValorCombo_SelectedIndexChanged);
            // 
            // lstRecebeEstadoDigitado
            // 
            this.lstRecebeEstadoDigitado.FormattingEnabled = true;
            this.lstRecebeEstadoDigitado.Location = new System.Drawing.Point(640, 370);
            this.lstRecebeEstadoDigitado.Name = "lstRecebeEstadoDigitado";
            this.lstRecebeEstadoDigitado.Size = new System.Drawing.Size(120, 95);
            this.lstRecebeEstadoDigitado.Sorted = true;
            this.lstRecebeEstadoDigitado.TabIndex = 1;
            // 
            // cmbAddViaPropriedade
            // 
            this.cmbAddViaPropriedade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddViaPropriedade.FormattingEnabled = true;
            this.cmbAddViaPropriedade.Items.AddRange(new object[] {
            "Acre",
            "Rio de Janeiro",
            "São Paulo"});
            this.cmbAddViaPropriedade.Location = new System.Drawing.Point(37, 139);
            this.cmbAddViaPropriedade.Name = "cmbAddViaPropriedade";
            this.cmbAddViaPropriedade.Size = new System.Drawing.Size(121, 21);
            this.cmbAddViaPropriedade.Sorted = true;
            this.cmbAddViaPropriedade.TabIndex = 2;
            this.cmbAddViaPropriedade.SelectedIndexChanged += new System.EventHandler(this.cmbAddViaPropriedade_SelectedIndexChanged);
            // 
            // cmbAddViaCod
            // 
            this.cmbAddViaCod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddViaCod.FormattingEnabled = true;
            this.cmbAddViaCod.Location = new System.Drawing.Point(250, 139);
            this.cmbAddViaCod.Name = "cmbAddViaCod";
            this.cmbAddViaCod.Size = new System.Drawing.Size(121, 21);
            this.cmbAddViaCod.Sorted = true;
            this.cmbAddViaCod.TabIndex = 3;
            // 
            // cmbCidade
            // 
            this.cmbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Location = new System.Drawing.Point(458, 139);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(121, 21);
            this.cmbCidade.Sorted = true;
            this.cmbCidade.TabIndex = 4;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(660, 140);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 5;
            this.txtEstado.Text = "\r\n";
            // 
            // txtRecebeValorCombo
            // 
            this.txtRecebeValorCombo.Location = new System.Drawing.Point(37, 297);
            this.txtRecebeValorCombo.Name = "txtRecebeValorCombo";
            this.txtRecebeValorCombo.Size = new System.Drawing.Size(100, 20);
            this.txtRecebeValorCombo.TabIndex = 6;
            // 
            // txtRecebeValorSemIf
            // 
            this.txtRecebeValorSemIf.Location = new System.Drawing.Point(250, 297);
            this.txtRecebeValorSemIf.Name = "txtRecebeValorSemIf";
            this.txtRecebeValorSemIf.Size = new System.Drawing.Size(100, 20);
            this.txtRecebeValorSemIf.TabIndex = 7;
            // 
            // txtRecebeValorList
            // 
            this.txtRecebeValorList.Location = new System.Drawing.Point(250, 383);
            this.txtRecebeValorList.Name = "txtRecebeValorList";
            this.txtRecebeValorList.Size = new System.Drawing.Size(100, 20);
            this.txtRecebeValorList.TabIndex = 8;
            // 
            // cmbRecebeEstado
            // 
            this.cmbRecebeEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecebeEstado.FormattingEnabled = true;
            this.cmbRecebeEstado.Location = new System.Drawing.Point(639, 232);
            this.cmbRecebeEstado.Name = "cmbRecebeEstado";
            this.cmbRecebeEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbRecebeEstado.Sorted = true;
            this.cmbRecebeEstado.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(801, 137);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOrdem
            // 
            this.btnOrdem.Location = new System.Drawing.Point(801, 197);
            this.btnOrdem.Name = "btnOrdem";
            this.btnOrdem.Size = new System.Drawing.Size(100, 25);
            this.btnOrdem.TabIndex = 11;
            this.btnOrdem.Text = "&Ordem";
            this.btnOrdem.UseVisualStyleBackColor = true;
            this.btnOrdem.Click += new System.EventHandler(this.btnOrdem_Click);
            // 
            // btnRemoveCombo
            // 
            this.btnRemoveCombo.Location = new System.Drawing.Point(794, 261);
            this.btnRemoveCombo.Name = "btnRemoveCombo";
            this.btnRemoveCombo.Size = new System.Drawing.Size(107, 23);
            this.btnRemoveCombo.TabIndex = 12;
            this.btnRemoveCombo.Text = "R&emove do Combo";
            this.btnRemoveCombo.UseVisualStyleBackColor = true;
            this.btnRemoveCombo.Click += new System.EventHandler(this.btnRemoveCombo_Click);
            // 
            // btnRemovedoList
            // 
            this.btnRemovedoList.Location = new System.Drawing.Point(794, 326);
            this.btnRemovedoList.Name = "btnRemovedoList";
            this.btnRemovedoList.Size = new System.Drawing.Size(107, 23);
            this.btnRemovedoList.TabIndex = 13;
            this.btnRemovedoList.Text = "&Remove do LIst";
            this.btnRemovedoList.UseVisualStyleBackColor = true;
            this.btnRemovedoList.Click += new System.EventHandler(this.btnRemovedoList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Valores Add via Propriedades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Valores Add via Propriedades";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Estado";
            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(657, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Digite um Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Text recebe valor de um Combo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Text recebe valor de um Combo sem if";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "List recebe valor de um Combo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(247, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Text recebe valor de um List sem IF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(931, 513);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemovedoList);
            this.Controls.Add(this.btnRemoveCombo);
            this.Controls.Add(this.btnOrdem);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbRecebeEstado);
            this.Controls.Add(this.txtRecebeValorList);
            this.Controls.Add(this.txtRecebeValorSemIf);
            this.Controls.Add(this.txtRecebeValorCombo);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.cmbCidade);
            this.Controls.Add(this.cmbAddViaCod);
            this.Controls.Add(this.cmbAddViaPropriedade);
            this.Controls.Add(this.lstRecebeEstadoDigitado);
            this.Controls.Add(this.lstRecebeValorCombo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRecebeValorCombo;
        private System.Windows.Forms.ListBox lstRecebeEstadoDigitado;
        private System.Windows.Forms.ComboBox cmbAddViaPropriedade;
        private System.Windows.Forms.ComboBox cmbAddViaCod;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtRecebeValorCombo;
        private System.Windows.Forms.TextBox txtRecebeValorSemIf;
        private System.Windows.Forms.TextBox txtRecebeValorList;
        private System.Windows.Forms.ComboBox cmbRecebeEstado;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOrdem;
        private System.Windows.Forms.Button btnRemoveCombo;
        private System.Windows.Forms.Button btnRemovedoList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

