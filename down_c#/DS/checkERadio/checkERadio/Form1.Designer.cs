namespace checkERadio
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
            this.grbComputadores = new System.Windows.Forms.GroupBox();
            this.grbEscritorio = new System.Windows.Forms.GroupBox();
            this.grbCompVendido = new System.Windows.Forms.GroupBox();
            this.grbProdEscritorioVendido = new System.Windows.Forms.GroupBox();
            this.rdbPC = new System.Windows.Forms.RadioButton();
            this.rdbMAC = new System.Windows.Forms.RadioButton();
            this.rdbNote = new System.Windows.Forms.RadioButton();
            this.ckbFax = new System.Windows.Forms.CheckBox();
            this.ckbCalculadora = new System.Windows.Forms.CheckBox();
            this.ckbCopiadora = new System.Windows.Forms.CheckBox();
            this.lblFax = new System.Windows.Forms.Label();
            this.lblCalculadora = new System.Windows.Forms.Label();
            this.lblCopiadora = new System.Windows.Forms.Label();
            this.lblComp = new System.Windows.Forms.Label();
            this.rdbCelular = new System.Windows.Forms.RadioButton();
            this.ckbPalmtop = new System.Windows.Forms.CheckBox();
            this.grbComputadores.SuspendLayout();
            this.grbEscritorio.SuspendLayout();
            this.grbCompVendido.SuspendLayout();
            this.grbProdEscritorioVendido.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbComputadores
            // 
            this.grbComputadores.BackColor = System.Drawing.Color.Transparent;
            this.grbComputadores.Controls.Add(this.rdbCelular);
            this.grbComputadores.Controls.Add(this.rdbNote);
            this.grbComputadores.Controls.Add(this.rdbMAC);
            this.grbComputadores.Controls.Add(this.rdbPC);
            this.grbComputadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbComputadores.ForeColor = System.Drawing.Color.Aqua;
            this.grbComputadores.Location = new System.Drawing.Point(41, 34);
            this.grbComputadores.Name = "grbComputadores";
            this.grbComputadores.Size = new System.Drawing.Size(200, 123);
            this.grbComputadores.TabIndex = 0;
            this.grbComputadores.TabStop = false;
            this.grbComputadores.Text = "Computadores";
            // 
            // grbEscritorio
            // 
            this.grbEscritorio.BackColor = System.Drawing.Color.Transparent;
            this.grbEscritorio.Controls.Add(this.ckbPalmtop);
            this.grbEscritorio.Controls.Add(this.ckbCopiadora);
            this.grbEscritorio.Controls.Add(this.ckbCalculadora);
            this.grbEscritorio.Controls.Add(this.ckbFax);
            this.grbEscritorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEscritorio.ForeColor = System.Drawing.Color.Aqua;
            this.grbEscritorio.Location = new System.Drawing.Point(41, 163);
            this.grbEscritorio.Name = "grbEscritorio";
            this.grbEscritorio.Size = new System.Drawing.Size(200, 133);
            this.grbEscritorio.TabIndex = 1;
            this.grbEscritorio.TabStop = false;
            this.grbEscritorio.Text = "Escritorio";
            // 
            // grbCompVendido
            // 
            this.grbCompVendido.BackColor = System.Drawing.Color.Transparent;
            this.grbCompVendido.Controls.Add(this.lblComp);
            this.grbCompVendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCompVendido.ForeColor = System.Drawing.Color.Aqua;
            this.grbCompVendido.Location = new System.Drawing.Point(333, 34);
            this.grbCompVendido.Name = "grbCompVendido";
            this.grbCompVendido.Size = new System.Drawing.Size(200, 123);
            this.grbCompVendido.TabIndex = 1;
            this.grbCompVendido.TabStop = false;
            this.grbCompVendido.Text = "Computador Vendido";
            // 
            // grbProdEscritorioVendido
            // 
            this.grbProdEscritorioVendido.BackColor = System.Drawing.Color.Transparent;
            this.grbProdEscritorioVendido.Controls.Add(this.lblCopiadora);
            this.grbProdEscritorioVendido.Controls.Add(this.lblCalculadora);
            this.grbProdEscritorioVendido.Controls.Add(this.lblFax);
            this.grbProdEscritorioVendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProdEscritorioVendido.ForeColor = System.Drawing.Color.Aqua;
            this.grbProdEscritorioVendido.Location = new System.Drawing.Point(333, 163);
            this.grbProdEscritorioVendido.Name = "grbProdEscritorioVendido";
            this.grbProdEscritorioVendido.Size = new System.Drawing.Size(200, 133);
            this.grbProdEscritorioVendido.TabIndex = 1;
            this.grbProdEscritorioVendido.TabStop = false;
            this.grbProdEscritorioVendido.Text = "Produtos de Escritório";
            // 
            // rdbPC
            // 
            this.rdbPC.AutoSize = true;
            this.rdbPC.Location = new System.Drawing.Point(21, 21);
            this.rdbPC.Name = "rdbPC";
            this.rdbPC.Size = new System.Drawing.Size(46, 20);
            this.rdbPC.TabIndex = 0;
            this.rdbPC.TabStop = true;
            this.rdbPC.Text = "PC";
            this.rdbPC.UseVisualStyleBackColor = true;
            this.rdbPC.CheckedChanged += new System.EventHandler(this.rdbPC_CheckedChanged);
            // 
            // rdbMAC
            // 
            this.rdbMAC.AutoSize = true;
            this.rdbMAC.Location = new System.Drawing.Point(21, 47);
            this.rdbMAC.Name = "rdbMAC";
            this.rdbMAC.Size = new System.Drawing.Size(58, 20);
            this.rdbMAC.TabIndex = 1;
            this.rdbMAC.TabStop = true;
            this.rdbMAC.Text = "MAC";
            this.rdbMAC.UseVisualStyleBackColor = true;
            this.rdbMAC.CheckedChanged += new System.EventHandler(this.rdbMAC_CheckedChanged);
            // 
            // rdbNote
            // 
            this.rdbNote.AutoSize = true;
            this.rdbNote.Location = new System.Drawing.Point(21, 73);
            this.rdbNote.Name = "rdbNote";
            this.rdbNote.Size = new System.Drawing.Size(94, 20);
            this.rdbNote.TabIndex = 2;
            this.rdbNote.TabStop = true;
            this.rdbNote.Text = "Notebook";
            this.rdbNote.UseVisualStyleBackColor = true;
            this.rdbNote.CheckedChanged += new System.EventHandler(this.rdbNote_CheckedChanged);
            // 
            // ckbFax
            // 
            this.ckbFax.AutoSize = true;
            this.ckbFax.Location = new System.Drawing.Point(21, 19);
            this.ckbFax.Name = "ckbFax";
            this.ckbFax.Size = new System.Drawing.Size(52, 20);
            this.ckbFax.TabIndex = 0;
            this.ckbFax.Text = "Fax";
            this.ckbFax.UseVisualStyleBackColor = true;
            this.ckbFax.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ckbCalculadora
            // 
            this.ckbCalculadora.AutoSize = true;
            this.ckbCalculadora.Location = new System.Drawing.Point(21, 50);
            this.ckbCalculadora.Name = "ckbCalculadora";
            this.ckbCalculadora.Size = new System.Drawing.Size(111, 20);
            this.ckbCalculadora.TabIndex = 1;
            this.ckbCalculadora.Text = "Calculadora";
            this.ckbCalculadora.UseVisualStyleBackColor = true;
            this.ckbCalculadora.CheckedChanged += new System.EventHandler(this.ckbCalculadora_CheckedChanged);
            // 
            // ckbCopiadora
            // 
            this.ckbCopiadora.AutoSize = true;
            this.ckbCopiadora.Location = new System.Drawing.Point(21, 77);
            this.ckbCopiadora.Name = "ckbCopiadora";
            this.ckbCopiadora.Size = new System.Drawing.Size(100, 20);
            this.ckbCopiadora.TabIndex = 2;
            this.ckbCopiadora.Text = "Copiadora";
            this.ckbCopiadora.UseVisualStyleBackColor = true;
            this.ckbCopiadora.CheckedChanged += new System.EventHandler(this.ckbCopiadora_CheckedChanged);
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(19, 17);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(0, 16);
            this.lblFax.TabIndex = 0;
            // 
            // lblCalculadora
            // 
            this.lblCalculadora.AutoSize = true;
            this.lblCalculadora.Location = new System.Drawing.Point(19, 48);
            this.lblCalculadora.Name = "lblCalculadora";
            this.lblCalculadora.Size = new System.Drawing.Size(0, 16);
            this.lblCalculadora.TabIndex = 1;
            // 
            // lblCopiadora
            // 
            this.lblCopiadora.AutoSize = true;
            this.lblCopiadora.Location = new System.Drawing.Point(19, 75);
            this.lblCopiadora.Name = "lblCopiadora";
            this.lblCopiadora.Size = new System.Drawing.Size(0, 16);
            this.lblCopiadora.TabIndex = 2;
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Location = new System.Drawing.Point(44, 54);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(0, 16);
            this.lblComp.TabIndex = 0;
            // 
            // rdbCelular
            // 
            this.rdbCelular.AutoSize = true;
            this.rdbCelular.Location = new System.Drawing.Point(21, 97);
            this.rdbCelular.Name = "rdbCelular";
            this.rdbCelular.Size = new System.Drawing.Size(75, 20);
            this.rdbCelular.TabIndex = 3;
            this.rdbCelular.TabStop = true;
            this.rdbCelular.Text = "Celular";
            this.rdbCelular.UseVisualStyleBackColor = true;
            this.rdbCelular.CheckedChanged += new System.EventHandler(this.rdbCelular_CheckedChanged);
            // 
            // ckbPalmtop
            // 
            this.ckbPalmtop.AutoSize = true;
            this.ckbPalmtop.Location = new System.Drawing.Point(21, 103);
            this.ckbPalmtop.Name = "ckbPalmtop";
            this.ckbPalmtop.Size = new System.Drawing.Size(83, 20);
            this.ckbPalmtop.TabIndex = 3;
            this.ckbPalmtop.Text = "palmtop";
            this.ckbPalmtop.UseVisualStyleBackColor = true;
            this.ckbPalmtop.CheckedChanged += new System.EventHandler(this.ckbPalmtop_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(571, 321);
            this.Controls.Add(this.grbEscritorio);
            this.Controls.Add(this.grbCompVendido);
            this.Controls.Add(this.grbProdEscritorioVendido);
            this.Controls.Add(this.grbComputadores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbComputadores.ResumeLayout(false);
            this.grbComputadores.PerformLayout();
            this.grbEscritorio.ResumeLayout(false);
            this.grbEscritorio.PerformLayout();
            this.grbCompVendido.ResumeLayout(false);
            this.grbCompVendido.PerformLayout();
            this.grbProdEscritorioVendido.ResumeLayout(false);
            this.grbProdEscritorioVendido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbComputadores;
        private System.Windows.Forms.RadioButton rdbNote;
        private System.Windows.Forms.RadioButton rdbMAC;
        private System.Windows.Forms.RadioButton rdbPC;
        private System.Windows.Forms.GroupBox grbEscritorio;
        private System.Windows.Forms.CheckBox ckbCopiadora;
        private System.Windows.Forms.CheckBox ckbCalculadora;
        private System.Windows.Forms.CheckBox ckbFax;
        private System.Windows.Forms.GroupBox grbCompVendido;
        private System.Windows.Forms.GroupBox grbProdEscritorioVendido;
        private System.Windows.Forms.Label lblCopiadora;
        private System.Windows.Forms.Label lblCalculadora;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.RadioButton rdbCelular;
        private System.Windows.Forms.CheckBox ckbPalmtop;
    }
}

