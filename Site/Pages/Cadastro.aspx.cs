using DAL.Model;
using DAL.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Site.Pages
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCadastrarPessoa(object sender, EventArgs e)
        {
            try
            {
                var p = new Pessoa()
                {
                    Nome            = txtNome.Text,
                    Email           = txtEmail.Text,
                    DataCadastro    = DateTime.Now                    
                };

                var end = new Endereco()
                {
                    Logradouro  = txtLogradouro.Text,
                    Cidade      = txtCidade.Text,
                    Estado      = txtEstado.Text,
                    Tipo        = rblTipo.SelectedValue
                };

                //Associar o Endereço a Pessoa:
                end.Pessoa = p;

                var d = new PessoalDal();
                d.Insert(p, end);

                EnviarMensagem(p);

                lblMensagem.Text = "Dados Gravados com sucesso";

                LimparCampos();              
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        private static void EnviarMensagem(Pessoa p)
        {
            //Envio de email:
            var msg = new MailMessage("seuemail@gmail.com", p.Email)
            {
                Subject = "Bem vindo ao Sistema",
                Body      = "Prezado(a) " + p.Nome + " você foi cadastrado com sucesso. "
            };

            //Configurar o protocolo SMTP:
            var smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl   = true,
                Credentials = new NetworkCredential("seuemail@gmail.com", "suasenha")
            };

            //Disparar o email:
            smtp.Send(msg);
        }

        private void LimparCampos()
        {
            txtNome.Text            = string.Empty;
            txtLogradouro.Text      = string.Empty;
            txtEstado.Text          = string.Empty;
            txtCidade.Text          = string.Empty;
            txtEmail.Text           = string.Empty;
            rblTipo.SelectedIndex   = -1;
        }
    }
}