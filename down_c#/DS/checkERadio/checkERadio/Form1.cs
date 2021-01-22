using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkERadio
{
    public partial class Form1 : Form
    {
        private object lblComputadores;

        public Form1()
        {
            InitializeComponent();
        }

        private void rdbPC_CheckedChanged(object sender, EventArgs e)
        {
            lblComp.Text = rdbPC.Text;
        }

        private void rdbMAC_CheckedChanged(object sender, EventArgs e)
        {
            lblComp.Text = rdbMAC.Text;
        }

        private void rdbNote_CheckedChanged(object sender, EventArgs e)
        {
            lblComp.Text = rdbNote.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFax.Checked == true)
            {
                lblFax.Text = ckbFax.Text;
            }
            else
            {
                lblFax.Text = "";
            }
        }

        private void ckbCalculadora_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCalculadora.Checked == true)
            {
                lblCalculadora.Text = ckbCalculadora.Text;
            }
            else
            {
                lblCalculadora.Text = "";
            }
        }

        private void ckbCopiadora_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCopiadora.Checked == true)
            {
                lblCopiadora.Text = ckbCopiadora.Text;
            }
            else
            {
                lblCopiadora.Text = "";
            }
        }

        private void rdbCelular_CheckedChanged(object sender, EventArgs e)
        {
            lblComp.Text = rdbCelular.Text;
        }

        private void ckbPalmtop_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPalmtop.Checked == true)
            {
                lblPalmtop.Text = ckbPalmtop.Text;
            }
            else
            {
                lblPalmtop.Text = "";
            }
        }
    }
}
