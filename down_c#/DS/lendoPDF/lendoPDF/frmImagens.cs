using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lendoPDF
{
    public partial class frmImagens : Form
    {
        public frmImagens()
        {
            InitializeComponent();
        }

        private void frmImagens_Load(object sender, EventArgs e)
        {

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            //abre o menu
            ofdSalvarFoto.ShowDialog();
            //criando o objeto que recebe a imagem
            Bitmap imagem = new Bitmap(ofdSalvarFoto.FileName);
            //criando um objeto imagem2,para redimensionar a imagem no tamanho do pcb
            Bitmap imagem2 = new Bitmap(imagem, pcbImagem.Size);

            //inserindo a img redimensionada no pcb
            pcbImagem.Image = imagem2;
            this.Validate();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                pcbImagem.Image.Save(Application.StartupPath.ToString() + "\\foto\\" + txtNomeImagem.Text +
                    ".png", System.Drawing.Imaging.ImageFormat.Png);
                pcbImagem.Image = null;
            }
            catch
            {
                MessageBox.Show("Não foi possivel salvar a imagem");
            }
        }
    }
}
