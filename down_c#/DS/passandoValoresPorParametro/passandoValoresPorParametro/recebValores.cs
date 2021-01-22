using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passandoValoresPorParametro
{
    public partial class recebValores : Form
    {
        public recebValores(string recebeTexto1, string recebeTexto2)
        {
            InitializeComponent();
            lblRecebeTexto1.Text = recebeTexto1;
            lblRecebeTexto2.Text = recebeTexto2;
        }

        private void recebValores_Load(object sender, EventArgs e)
        {

        }
    }
}
