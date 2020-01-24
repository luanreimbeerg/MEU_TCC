using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace FastCare.Telas.CRM
{
    public partial class frmPromocao : Form
    {
        public frmPromocao()
        {
            InitializeComponent();
        }

        private void EnviarSms(string telpara, string texto)
        {
            telpara = telpara.Replace("(", "").Replace(")", "").Replace("-", "");

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            TwilioClient.Init("ACcfa1c59b196f5d242251ea78c4067914", "d796933e40301278b07e351949e6fa1d");

            var message = MessageResource.Create(
        new PhoneNumber(telpara),
             from: new PhoneNumber("+12406508516"),
        body: texto);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string telpara = txtCel.Text;
            string texto = txtMensagem.Text;

            this.EnviarSms(telpara, texto);

            MessageBox.Show("SMS Enviado com sucesso", "Fast Care", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void EnviarWhats(string telpara, string texto)
        {

            telpara = telpara.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            TwilioClient.Init("ACcfa1c59b196f5d242251ea78c4067914", "d796933e40301278b07e351949e6fa1d");

            var message = MessageResource.Create(
        new PhoneNumber("whatsapp:" + telpara),
             from: new PhoneNumber("whatsapp:+14155238886"),
        body: texto);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string telpara = txtCel.Text;
            string texto = txtMensagem.Text;

            this.EnviarWhats(telpara, texto);

            MessageBox.Show("Whatsapp Eviado com sucesso", "Fast Care", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ImgBack_Click(object sender, EventArgs e)
        {
            Outros.frmMenuGerente tela = new Outros.frmMenuGerente();
            tela.Show();
            Hide();
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(196, 231, 167);
            button3.ForeColor = Color.Black;
        }

        private void ImgBack_MouseEnter(object sender, EventArgs e)
        {
            ImgBack.BackColor = Color.White;
        }

        private void ImgBack_MouseLeave(object sender, EventArgs e)
        {
            ImgBack.ForeColor = Color.FromArgb(196, 231, 167);
        }
    }
}
