using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meusegundoprograma
{
    
    public partial class frmCalculadora : Form
    {
        string operador;
        int a = 0;
        bool validar = false;
        
    

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnNumerador_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtValor.Text = txtValor.Text + bt.Text;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            label1.Text = "";
            a = 0;
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if(validar == true)
            {
                a = a + Convert.ToInt32(txtValor.Text);
                label1.Text = Convert.ToString(a) + "+";
                txtValor.Text = "";
                operador = "+";
            }   
            else
            {
                label1.Text = txtValor.Text + btnSomar.Text;
                a = Convert.ToInt32(txtValor.Text);
                txtValor.Text = "";
                operador = "+";
                validar = true;
            }
        }

        private void btnMultiplicação_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a * Convert.ToInt32(txtValor.Text);
                label1.Text = Convert.ToString(a) + "*";
                txtValor.Text = "";
                operador = "*";
            }
            else
            {
                label1.Text = txtValor.Text + btnMultiplicação.Text;
                a = Convert.ToInt32(txtValor.Text);
                txtValor.Text = "";
                operador = "*";
                validar = true;
            }
        }

        private void btnSubtração_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a - Convert.ToInt32(txtValor.Text);
                label1.Text = Convert.ToString(a) + "-";
                txtValor.Text = "";
                operador = "-";
            }
            else
            {
                label1.Text = txtValor.Text + btnSubtração.Text;
                a = Convert.ToInt32(txtValor.Text);
                txtValor.Text = "";
                operador = "-";
                validar = true;
            }
        }

        private void btnDivizão_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a / Convert.ToInt32(txtValor.Text);
                label1.Text = Convert.ToString(a) + "/";
                txtValor.Text = "";
                operador = "/";
            }
            else
            {
                label1.Text = txtValor.Text + btnDivizão.Text;
                a = Convert.ToInt32(txtValor.Text);
                txtValor.Text = "";
                operador = "/";
                validar = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (operador == "+")
            {
                label1.Text = label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a + Convert.ToInt32(txtValor.Text));
            }
            else if (operador == "-")
            {
                label1.Text = label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a - Convert.ToInt32(txtValor.Text));
            }
            else if (operador == "*")
            {
                label1.Text = label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a * Convert.ToInt32(txtValor.Text));
            }
            else if (operador == "/")
            {
                label1.Text = label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a / Convert.ToInt32(txtValor.Text));
            }
        }
    }
}
