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
    public partial class frmEmail : Form
    {
        string recebeSMTP;
        int porta;
        public frmEmail()
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
                msg.From = new System.Net.Mail.MailAddress(txtDe.Text);
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
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient(recebeSMTP,porta);
                //habilitando a criptografia
                smtp.EnableSsl = true;
                //criando a credencial
                smtp.Credentials = new System.Net.NetworkCredential(txtDe.Text, txtSenha.Text);
                //enviando...
                smtp.Send(msg);
                MessageBox.Show("Mensagem Enviada com Sucesso!!!");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void cmbTipoemail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoemail.Text.Equals("@etec.sp.gov.br"))
            {
                recebeSMTP = "smtp.office365.com";
                porta = 587;
            }
            if (cmbTipoemail.Text.Equals("@yahoo.com.br"))
            {
                recebeSMTP = "smtp.mail.yahoo.com";
                porta = 465;
            }
            if (cmbTipoemail.Text.Equals("@outlook.com"))
            {
                recebeSMTP = "smtp-mail.outlook.com";
                porta = 587;
            }
        }
    }
}
