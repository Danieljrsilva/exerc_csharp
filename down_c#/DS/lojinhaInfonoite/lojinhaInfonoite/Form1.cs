using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lojinhaInfonoite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool verificaTextVazio()
        {
            foreach (Control verifica in this.Controls)
                if(verifica is TextBox)
                {
                    TextBox estatus = verifica as TextBox;
                    if(string.IsNullOrWhiteSpace(estatus.Text))
                    {
                        return true;
                    }
                }
            return false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (verificaTextVazio())
            {
                MessageBox.Show("Favor preencher todos os campos");
            }
            else
            {

                double preco1, preco2, preco3, preco4, totBruto, totLiq;
                double desc;

                //convertendo os valores
                preco1 = Convert.ToDouble(txtPreco1.Text);
                preco2 = Convert.ToDouble(txtPreco2.Text);
                preco3 = Convert.ToDouble(txtPreco3.Text);
                preco4 = Convert.ToDouble(txtPreco4.Text);
                desc = Convert.ToDouble(txtDesconto.Text);

                //pegando os valores e calculando
                totBruto = preco1 + preco2 + preco3 + preco4;
                totLiq = totBruto - (totBruto * desc) / 100;
                desc = (totBruto * desc) / 100;

                //DEPOIS DE FAZER O CÁLCULO,HABILITAR O GROUP
                grbMostraValores.Visible = true;
                grbValoresTotais.Visible = true;

                //passando os valores dos calculos
                txtVLRDesconto.Text = Convert.ToString(desc);
                txtTotBruto.Text = Convert.ToString(totBruto);
                txtTotLiq.Text = Convert.ToString(totLiq);

                //depois de habilitar o group,vamos passar os valores
                lblProduto1.Text = "Voçê comprou: " + txtProduto1.Text;
                lblProduto2.Text = "Voçê comprou: " + txtProduto2.Text;
                lblProduto3.Text = "Voçê comprou: " + txtProduto3.Text;
                lblProduto4.Text = "Voçê comprou: " + txtProduto4.Text;

                lblPreco1.Text = "R$ " + txtPreco1.Text + " a unidade";
                lblPreco2.Text = "R$ " + txtPreco2.Text + " a unidade";
                lblPreco3.Text = "R$ " + txtPreco3.Text + " a unidade";
                lblPreco4.Text = "R$ " + txtPreco4.Text + " a unidade";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            foreach(Control LimparText in this.Controls)
            {
                if(LimparText is TextBox)
                {
                    (LimparText as TextBox).Clear();
                }
               
            }
            grbMostraValores.Visible = false;
            grbValoresTotais.Visible = false;
        }
    }
}
