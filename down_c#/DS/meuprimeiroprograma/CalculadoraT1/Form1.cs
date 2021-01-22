using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraT1
{
    public partial class Form1 : Form
    {
        //declarando variável global
        double totSub, totsoma,totmult,totdiv, valor1, valor2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            AcionandoBips();
            txtNum1.Clear();
            txtNum1.Clear();
            txtResultado.Visible = false;
            lblResultado.Visible = false;


        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            //chamando método
            AcionandoBips();
            dadosBasicos();
            //após chamar o método dadosBasicos, vms fazer a conta
            totdiv = valor1 / valor2;
            //enviando resultado para o text
            txtResultado.Text = Convert.ToString(totdiv);
            //fazendo aparecer o txtResultado
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            AcionandoBips();
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            //chamando método
            AcionandoBips();
            dadosBasicos();
            //após chamar o método dadosBasicos, vms fazer a conta
            totmult = valor1 * valor2;
            //enviando resultado para o text
            txtResultado.Text = Convert.ToString(totmult);
            //fazendo aparecer o txtResultado
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            //chamando método
            AcionandoBips();
            dadosBasicos();
            //após chamar o método dadosBasicos, vms fazer a conta
            totSub = valor1 - valor2;
            //enviando resultado para o text
            txtResultado.Text = Convert.ToString(totSub);
            //fazendo aparecer o txtResultado
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            //chamando método
            AcionandoBips();
            dadosBasicos();
            //após chamar o método dadosBasicos, vms fazer a conta
            totsoma = valor1 + valor2;
            //enviando resultado para o text
            txtResultado.Text = Convert.ToString(totsoma);
            //fazendo aparecer o txtResultado
           
            
        }

        //criamos um método onde todos os botões irão utilizar
        public void dadosBasicos()
        {
            
            //verificando de os txts estão vazios
            if(txtNum1.Text == "" || txtNum2.Text=="")
            {
                MessageBox.Show("É preciso ter valores nos texts");
            }
            else
            {
                valor1 = Convert.ToDouble(txtNum1.Text);
                valor2 = Convert.ToDouble(txtNum2.Text);
                txtResultado.Visible = true;
                lblResultado.Visible = true;
            }
        }
        public void AcionandoBips()
        {
            //chamando o som padrão do windows
            System.Media.SystemSounds.Beep.Play();
            Console.Beep(1500, 100);
            //o 5000 corresponde a frequencia e o 1000 a 1 seg
        }
    }
}
