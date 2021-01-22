using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaEmerson
{
    public partial class Segunda_Tela : Form
    {
        private object lblRecebeTexto1;
        private object lblRecebeTexto2;
        private string txtNome;

        public Segunda_Tela()
        {
            InitializeComponent();
        }


        public Segunda_Tela(string recebeTexto1, string recebeTexto2)
        {
            InitializeComponent();
            txtRecebeNome.Text = recebeTexto1;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void dadosBasicos()
        {
            //verificando de os txts estão vazios
            if (cmbIdade.Text == "" )
            {
                MessageBox.Show("É preciso inserir valores");
            }


        }

        private void txtRecebeNome_TextChanged(object sender, EventArgs e)
        {
            InitializeComponent();
            lblSeuNome.Text = txtNome;
          

        }

        private void btnProcessarDados_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRecebeNome.Text)){
                MessageBox.Show("Favor preencher os dois valores");
            }
            else
            {
                if (lblRecebeNome = lblRecebeNome = (""); 
            }

        }
    }
}
