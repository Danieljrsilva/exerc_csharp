using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teclasDeAtalho
{
    public partial class frmTeclasDeAtalho : Form
    {
        public frmTeclasDeAtalho()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmTeclasDeAtalho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                //chama o evento clik do btnNovoForm
                btnChamaNovoForm.PerformClick();
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnHoraAtual.PerformClick();
            }
            else if(e.KeyCode == Keys.F3)
            {
                btnSair.PerformClick();
            }
        }

        private void btnChamaNovoForm_Click(object sender, EventArgs e)
        {
            //primeiro: Devemos criar o obj do form
            frmMenu abrirFrmMenu = new frmMenu();
            //agora,vamos abri-lo
            abrirFrmMenu.ShowDialog();
        }

        private void btnHoraAtual_Click(object sender, EventArgs e)
        {
              
        }
    }
}
