using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorioETEC
{
    public partial class frmLabETEC : Form
    {
        public frmLabETEC()
        {
            InitializeComponent();
        }
        double vlrTotal = 0.0, vlrFinal = 0.0;
        double vlrDesconto = 0.0;
        private void frmLabETEC_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmaDados_Click(object sender, EventArgs e)
        {
            if (txtNomePaciente.Text == "" || txtIdade.Text == "" || cmbSexo.Text == "")
            {
                MessageBox.Show("É precizo preencher os 3 campos");
            }
            else
            {
                btnConfirmaDados.Enabled = false;
                txtNomePaciente.Enabled = false;
                txtIdade.Enabled = false;
                cmbSexo.Enabled = false;
                grbExames.Visible = true;
                grbConvenio.Visible = true;
                grbValores.Visible = true;
                btnLimpar.Visible = true;
            }
        }

        private void grbExames_Enter(object sender, EventArgs e)
        {

        }

        private void grbConvenio_Enter(object sender, EventArgs e)
        {
           /* if (rdbNao.Checked == true || rdbSim.Checked == true)
            {
                btnCalcular.Visible = true;
                btnLimpar.Visible = true;
                btnSair.Visible = true;
            }*/
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            /*if (rdbSim.Checked == false && rdbNao.Checked == false)
            {
                MessageBox.Show("Favor selecionar se há ou não convenio");
            }
            else
            {
                grbValores.Visible = true;

                double vlrTotal = 0.0;

                if (ckbAcidoUrico.Checked == true)
                {
                    vlrTotal = vlrTotal + 50;
                }
                if (ckbColesterol.Checked == true)
                {
                    vlrTotal = vlrTotal + 50;
                }
                if (ckbCopro.Checked == true)
                {
                    vlrTotal = vlrTotal + 50;
                }
                if (ckbGlicose.Checked == true)
                {
                    vlrTotal = vlrTotal + 50;
                }
                if (ckbHemograma.Checked == true)
                {
                    vlrTotal = vlrTotal + 50;
                }
                if (ckbProto.Checked == true)
                {
                    vlrTotal = vlrTotal + 50;
                }
                if (ckbTSH.Checked == true)
                {
                    vlrTotal = vlrTotal + 50;
                }
                if (ckbUreia.Checked == true)
                {
                    vlrTotal = vlrTotal + 50;
                }
                if (ckbUrina.Checked == true)
                {
                    vlrTotal = vlrTotal + 50;
                }

                //passa o vlrTotal para o vlrFinal
                vlrFinal = vlrTotal;
                //desconto
                if (rdbSim.Checked == true)
                {
                    //desconto de 20%
                    vlrFinal = vlrTotal * 0.80;
                    txtValorAPagar.Text = Convert.ToString(vlrFinal);
                }
                else
                {
                    txtValorAPagar.Text = Convert.ToString(vlrFinal);
                }

                //zerando o vlrTotal para que ele não fique duplicando os valores
                vlrTotal = 0.0;

            }*/

        }

        private void ckbHemograma_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHemograma.Checked == true)
            {
                vlrTotal = vlrTotal + 50;
                txtValorAPagar.Text = Convert.ToString(vlrTotal);
            }
            else if (ckbHemograma.Checked == true && rdbSim.Checked == true)
            {
                vlrDesconto = vlrTotal * 0.80;
                txtValorAPagar.Text = Convert.ToString(vlrDesconto);
            }
            else
            {
                vlrTotal = vlrTotal - 50;
                txtValorAPagar.Text = Convert.ToString(vlrTotal);
            }
        }       

        private void txtValorRecebido_TextChanged(object sender, EventArgs e)
        {
            if (txtValorRecebido.Text == "")
            {
                txtValorRecebido.Focus();
                txtTroco.Text = "0";
            }
            else
            {
                double troco, vlrRecebido;
                vlrRecebido = Convert.ToDouble(txtValorRecebido.Text);
                troco = vlrRecebido - vlrFinal;
                txtTroco.Text = Convert.ToString(troco);
            }
        
        }
    }
}
