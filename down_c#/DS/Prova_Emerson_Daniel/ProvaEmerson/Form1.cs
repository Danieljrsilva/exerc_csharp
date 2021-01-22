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
    public partial class Form1 : Form
    {
        //variavel global
        string texto1, texto2;
        public Form1()
        {
            InitializeComponent();
        }

    

        private void btnPróximaTela_Click(object sender, EventArgs e)
        {
            //passando valor digitado para as vars
            texto1 = txtNome.Text;
            dadosBasicos();
            //abrindo o novo form e enviando os valores junto
            Segunda_Tela abrirForm = new Segunda_Tela(texto1, texto2);
            abrirForm.ShowDialog();
            
        }

        private void rdbNão_CheckedChanged(object sender, EventArgs e)
        {
            Close();
        }

        public void dadosBasicos()
        {
            //verificando de os txts estão vazios
            if (txtNome.Text == "" || rdbNão.Text == "" || rdbSim.Text == "")
            {
                MessageBox.Show("É preciso ter valores nos texts");
            }
            else
            {
                txtNome = true;
            }
        }

  


    }
}
