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
    public partial class frmPDF : Form
    {

        //criando o objeto para abrir o OpenFile
        OpenFileDialog abrirArquivos = new OpenFileDialog();

        public frmPDF()
        {
            InitializeComponent();
        }

        private void abrirArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //colocando os parametros do OpenFileDialog para PDF
            abrirArquivos.Filter = "Arquivos PDF * .pdf|* .pdf";

            //mudando o titulo da OpenFileDialog
            abrirArquivos.Title = "Abrir Arquivos PDF";

            //abrindo o OpenFileDialog
            abrirArquivos.ShowDialog();

            //verificando se algum arquivo foi selecionado
            if(abrirArquivos.FileName!="")
            {
                pdfleitor.LoadFile(abrirArquivos.FileName);
            }
            else
            {
                return;
            }
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!pdfleitor.LoadFile(abrirArquivos.FileName))
            {
                MessageBox.Show("Favor primeiro abrir um arquivo PDF");
            }
            else
            {
                pdfleitor.printWithDialog();
            }
        }

        private void abrirImagensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImagens abrirImagens = new frmImagens();
            abrirImagens.ShowDialog();
        }
    }
}
