namespace teclasDeAtalho
{
    partial class frmTeclasDeAtalho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeclasDeAtalho));
            this.btnChamaNovoForm = new System.Windows.Forms.Button();
            this.btnHoraAtual = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.trmHoraAtual = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnChamaNovoForm
            // 
            this.btnChamaNovoForm.BackColor = System.Drawing.Color.Transparent;
            this.btnChamaNovoForm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnChamaNovoForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamaNovoForm.ForeColor = System.Drawing.Color.Teal;
            this.btnChamaNovoForm.Location = new System.Drawing.Point(23, 46);
            this.btnChamaNovoForm.Name = "btnChamaNovoForm";
            this.btnChamaNovoForm.Size = new System.Drawing.Size(147, 49);
            this.btnChamaNovoForm.TabIndex = 0;
            this.btnChamaNovoForm.Text = "&Chamar Novo Form-F1";
            this.btnChamaNovoForm.UseVisualStyleBackColor = false;
            this.btnChamaNovoForm.Click += new System.EventHandler(this.btnChamaNovoForm_Click);
            // 
            // btnHoraAtual
            // 
            this.btnHoraAtual.BackColor = System.Drawing.Color.Transparent;
            this.btnHoraAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoraAtual.ForeColor = System.Drawing.Color.Teal;
            this.btnHoraAtual.Location = new System.Drawing.Point(201, 146);
            this.btnHoraAtual.Name = "btnHoraAtual";
            this.btnHoraAtual.Size = new System.Drawing.Size(142, 48);
            this.btnHoraAtual.TabIndex = 1;
            this.btnHoraAtual.Text = "Hora Atual-F2";
            this.btnHoraAtual.UseVisualStyleBackColor = false;
            this.btnHoraAtual.Click += new System.EventHandler(this.btnHoraAtual_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Teal;
            this.btnSair.Location = new System.Drawing.Point(371, 254);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(143, 47);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair-F3";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.button3_Click);
            // 
            // trmHoraAtual
            // 
            this.trmHoraAtual.Enabled = true;
            this.trmHoraAtual.Interval = 1000;
            // 
            // frmTeclasDeAtalho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 337);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnHoraAtual);
            this.Controls.Add(this.btnChamaNovoForm);
            this.KeyPreview = true;
            this.Name = "frmTeclasDeAtalho";
            this.Text = "Teclas de Atalho";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTeclasDeAtalho_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChamaNovoForm;
        private System.Windows.Forms.Button btnHoraAtual;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Timer trmHoraAtual;
    }
}

