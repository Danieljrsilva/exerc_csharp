namespace passandoValoresPorParametro
{
    partial class recebValores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recebValores));
            this.lblRecebeTexto1 = new System.Windows.Forms.Label();
            this.lblRecebeTexto2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRecebeTexto1
            // 
            this.lblRecebeTexto1.AutoSize = true;
            this.lblRecebeTexto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecebeTexto1.Location = new System.Drawing.Point(195, 78);
            this.lblRecebeTexto1.Name = "lblRecebeTexto1";
            this.lblRecebeTexto1.Size = new System.Drawing.Size(0, 16);
            this.lblRecebeTexto1.TabIndex = 0;
            // 
            // lblRecebeTexto2
            // 
            this.lblRecebeTexto2.AutoSize = true;
            this.lblRecebeTexto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecebeTexto2.Location = new System.Drawing.Point(195, 170);
            this.lblRecebeTexto2.Name = "lblRecebeTexto2";
            this.lblRecebeTexto2.Size = new System.Drawing.Size(0, 16);
            this.lblRecebeTexto2.TabIndex = 1;
            // 
            // recebValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(561, 353);
            this.Controls.Add(this.lblRecebeTexto2);
            this.Controls.Add(this.lblRecebeTexto1);
            this.Name = "recebValores";
            this.Text = "recebValores";
            this.Load += new System.EventHandler(this.recebValores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecebeTexto1;
        private System.Windows.Forms.Label lblRecebeTexto2;
    }
}