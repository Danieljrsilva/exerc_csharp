using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passandoValoresPorParametro
{
    public partial class frmPrincipal : Form
    {
        //variavel global
        string texto1, texto2;
        public frmPrincipal()
        { 
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //passando valor digitado para as vars
            texto1 = txtDadosAEnviar1.Text;
            texto2 = txtDadosAEnviar2.Text;

            //abrindo o novo form e enviando os valores junto
            recebValores abrirForm = new recebValores(texto1, texto2);
            abrirForm.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
