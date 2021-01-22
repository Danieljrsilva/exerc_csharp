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
        //criando o obj para n°s randomicos para os labels
        Random geraRandomico = new Random();
        //criando as variaveis
        int num1, num2, num3;
        public frmSeteDaSorte()
        {
            InitializeComponent();
        }

     

        private void btnJogar_Click(object sender, EventArgs e)
        {
            trmNum1.Enabled = true;
            trmNum2.Enabled = true;
            trmNum3.Enabled = true;
        }

        private void trmNum1_Tick(object sender, EventArgs e)
        {
            atribuirNum1();
            condicaoNum1();
        }

        private void trmNum2_Tick(object sender, EventArgs e)
        {
            atribuirNum2();
            condicaoNum2();
        }

        private void trmNum3_Tick(object sender, EventArgs e)
        {
            atribuirNum3();
            condicaoNum3();
        }

        public void atribuirNum1()
        {
            num1 = geraRandomico.Next(0, 9);
            lblNum1.Text = Convert.ToString(num1);
        }

        public void condicaoNum1()
        {
            if (pgbSeteDaSorte.Value >= 100)
            {
                pgbSeteDaSorte.Value = 0;
                trmNum1.Enabled = false;
                lblNum1.ForeColor = System.Drawing.Color.Blue;
                //resultado();
            }
            else
            {
                pgbSeteDaSorte.Value += 2;
            }
        }

        public void atribuirNum2()
        {
            num2 = geraRandomico.Next(0, 9);
            lblNum2.Text = Convert.ToString(num2);
        }

        public void condicaoNum2()
        {
            if (pgbSeteDaSorte.Value >= 100)
            {
                pgbSeteDaSorte.Value = 0;
                trmNum2.Enabled = false;
                lblNum2.ForeColor = System.Drawing.Color.Blue;
                //resultado();
            }
            else
            {
                pgbSeteDaSorte.Value += 4;
            }
        }

        public void atribuirNum3()
        {
            num3 = geraRandomico.Next(0, 9);
            lblNum3.Text = Convert.ToString(num3);
        }

        public void condicaoNum3()
        {
            if (pgbSeteDaSorte.Value >= 100)
            {
                pgbSeteDaSorte.Value = 0;
                trmNum3.Enabled = false;
                lblNum3.ForeColor = System.Drawing.Color.Blue;
                //resultado();
            }
            else
            {
                pgbSeteDaSorte.Value += 5;
            }
        }

        public void resultado()
        {
            if ((trmNum1.Enabled == false) && (trmNum2.Enabled == false) && (trmNum3.Enabled == false))
            {
                if ((num1 == 7) && (num2 == 7) && (num3 == 7))
                {
                    //somVitoria.Play();
                    MessageBox.Show("Parabens voçê ganhou");
                }
                else
                {
                    MessageBox.Show("Não fi dessa vez");
                }
            }
        }
    }
}
