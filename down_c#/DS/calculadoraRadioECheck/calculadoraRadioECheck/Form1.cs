using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraRadioECheck
{
    public partial class frmCalculadora : Form
    {
        double num1, num2, total;
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void rdb5_CheckedChanged(object sender, EventArgs e)
        {
            txtTotAcres.Text = Convert.ToString(total + 5);
        }

        private void rdb15_CheckedChanged(object sender, EventArgs e)
        {
            txtTotAcres.Text = Convert.ToString(total + 15);
        }

        private void rdb10_CheckedChanged(object sender, EventArgs e)
        {
            txtTotAcres.Text = Convert.ToString(total + 10);
        }

        private void rdb20_CheckedChanged(object sender, EventArgs e)
        {
            txtTotAcres.Text = Convert.ToString(total + 20);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblRecebeHora.Text = DateTime.Now.ToLongTimeString();
            lblRecebeData.Text = DateTime.Now.ToLongDateString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNum1.Text) || string.IsNullOrWhiteSpace(txtNum2.Text)) 
            {
                MessageBox.Show("Favor preencher os dois valores");
            }
            else
            {
                num1 = Convert.ToDouble(txtNum1.Text);
                num2 = Convert.ToDouble(txtNum2.Text);

                if(rdbAdicicao.AutoCheck == true)
                {
                    total = num1 + num2;
                }
                else if(rdbDivizao.Checked == true)
                {
                    total = num1 / num2;
                }
                else if(rdbMultiplicacao.Checked == true)
                {
                    total = num1 * num2;
                }
                else if(rdbRestoDiv.Checked == true)
                {
                    total = num1 % num2;
                }
                else if(rdbSubtracao.Checked == true)
                {
                    total = num1 - num2;
                }
                else
                {
                    MessageBox.Show("Favor selecionar algum calculo");
                }
                //passando p vlr do calculo
                txtResultado.Text = Convert.ToString(total);
            }
        }

    }   
}
