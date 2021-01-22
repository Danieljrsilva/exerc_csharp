using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seteDaSorte
{
    public partial class frmSeteDaSorte : Form
    {
        public frmSeteDaSorte()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            //criando o obj para n°s randomicos para os labels
            Random geraRandomico = new Random();

            int num1, num2, num3;

            //criando os numeros randonicos
            num1 = geraRandomico.Next(0, 9);
            num2 = geraRandomico.Next(0, 9);
            num3 = geraRandomico.Next(0, 9);

            //colocando num nos labels
            lblNum1.Text = Convert.ToString(num1);
            lblNum2.Text = Convert.ToString(num2);
            lblNum3.Text = Convert.ToString(num3);

            if (num1==7 && num2 == 7 && num3==7)
            {
                pcbImageJogo.Image = Properties.Resources.vitoria;
            }
            else
            {
                pcbImageJogo.Image = Properties.Resources.derrota;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
