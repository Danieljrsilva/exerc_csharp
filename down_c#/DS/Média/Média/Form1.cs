using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Média
{
    public partial class frmMedia : Form
    {
        public frmMedia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, nota4, media;
            string situacao;

            //convertendo as notas
            nota1 = Convert.ToDouble(txtNota1.Text);
            nota2 = Convert.ToDouble(txtNota2.Text);
            nota3 = Convert.ToDouble(txtNota3.Text);
            nota4 = Convert.ToDouble(txtNota4.Text);

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if(media < 4)
            {
                lblSituacao.ForeColor = System.Drawing.Color.Red;
                lblSituacao.Text = "Reprocavod ; -(";
            }
            else if (media < 7)
            {
                lblSituacao.ForeColor = System.Drawing.Color.Yellow;
                lblSituacao.Text = "Ufa, tá dentro. Boas férias :-)";
            }
            else if (media < 8.5)
            {
                lblSituacao.ForeColor = System.Drawing.Color.Green;
                lblSituacao.Text = "Você foi muito bem. Parabéns! :-)";
            }
            else
            {
                lblSituacao.ForeColor = System.Drawing.Color.Blue;
                lblSituacao.Text = "Espetacular Xuxu. Parabéns! ;-)";
            }
            lblMedia.Text = Convert.ToString(media);
        }

        private void txtNota3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
