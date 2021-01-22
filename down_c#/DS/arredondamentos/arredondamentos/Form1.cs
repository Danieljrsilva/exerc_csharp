using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arredondamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtValor1.Text) || string.IsNullOrEmpty(txtValor2.Text))
            {
                
                MessageBox.Show("Favor digitar valores rmo text");
            }
            else
            {
                //declarando variavel para realizar os arredondamentos
                double num1, num2, result, arredondamento, maxArred, minArred;
                //passando valores dos texts para as vars
                num1 = Convert.ToDouble(txtValor1.Text);
                num2 = Convert.ToDouble(txtValor2.Text);

                //realizando um cálculo
                result = num1 / num2;

                //passando o valor da divizao para o label
                lblSemTratamento.Text = Convert.ToString(result); 

                //usando a fórmula de arredondamento para cima
                maxArred = Math.Ceiling(result);
                lblParaCima.Text = Convert.ToString(maxArred);

                //usando a fórmula de arredondamento para baixo
                minArred = Math.Floor(result);
                lblParaBaixo.Text = Convert.ToString(minArred);

                //arredondamento por aproximação
                arredondamento = Math.Round(result);
                lblAproximacao.Text = Convert.ToString(arredondamento);

                //arredondamento pro casas decimais
                lblCasasDecimais.Text = Convert.ToString(Math.Round(result, 2));
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtValor2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
