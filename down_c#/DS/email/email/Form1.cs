using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace email
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnexo_Click(object sender, EventArgs e)
        {
            //chamando o ofd
            ofdAnexo.ShowDialog();
            //passando o caminho
            txtAnexo.Text = ofdAnexo.FileName;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                //classe MailMessage
                //criando o objeto para enviar mensagem via web
                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                //identificando o destinatario
                msg.To.Add(txtPara.Text);
                //pegando o e-mail de que ira enviar dados
                msg.From = new System.Net.Mail.MailAddress("dr345980@gmail.com");
                //pegando o assunto do e-mail
                msg.Subject = txtAssunto.Text;
                //pegando o conteudo do e-mail
                msg.Body = txtMensagem.Text;

                //******************************************************************
                //pegando o caminho
                System.Net.Mail.Attachment anexo = new System.Net.Mail.Attachment(txtAnexo.Text);
                //pegando o anexo da mensagem
                msg.Attachments.Add(anexo);

                //*******************************************************************
                //agora, coloque o SMTP e a prota de deu e-mail
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.office365.com");
                //habilitando a criptografia
                smtp.EnableSsl = true;
                //criando a credencial
                smtp.Credentials = new System.Net.NetworkCredential("daniel.silva969@etec.sp.gov.br");
                //enviando...
                smtp.Send(msg);
                MessageBox.Show("Mensagem Enviada com Sucesso!!!");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
