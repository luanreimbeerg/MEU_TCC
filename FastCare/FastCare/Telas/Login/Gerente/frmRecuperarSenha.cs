using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastCare.Telas.Login.Gerente
{
    public partial class frmRecuperarSenha : Form
    {
        int tempo = 60;

        public frmRecuperarSenha()
        {
            InitializeComponent();

            lblEmail.Text = Model.Entities.UsuarioLogado.email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chave = txtKey.Text;

            if (chave == Model.Entities.UsuarioLogado.chave)
            {
                frmAlterarSenha tela = new frmAlterarSenha();
                tela.Show();
                Hide();
            }
            else
                MessageBox.Show("Código inválido", "Fast Care", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnReenviarCodigo_Click(object sender, EventArgs e)
        {
            Utils.GeradorDeCodigos gerador = new Utils.GeradorDeCodigos();
            APIs.ApiGmailSender gmail = new APIs.ApiGmailSender();
            string codigo = gerador.GerarCodigo();

            string para = Model.Entities.UsuarioLogado.email;
            string assunto = "Recuperação de senha - Fast Care";
            string mensagem = "O seu código de verificação é " + codigo;

            gmail.Enviar(para, assunto, mensagem);

            Model.Entities.UsuarioLogado.chave = codigo;
            lblEspera.Visible = true;
            timer1.Start();

            MessageBox.Show("O código foi reenviado com sucesso", "Fast Care", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnReenviarCodigo.Enabled = false;
            tempo = 60;
        }

        private void btnReescreverEmail_Click(object sender, EventArgs e)
        {
            frmEsqueceuSenha tela = new frmEsqueceuSenha();
            tela.Show();
            Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tempo == 0)
            {
                lblEspera.Visible = false;
                timer1.Stop();
                btnReenviarCodigo.Enabled = true;
            }

            tempo = tempo - 1;
            lblEspera.Text = "Espere " + tempo.ToString() + " segundos para reenviar outro código";
        }

        private void ImgBack_Click(object sender, EventArgs e)
        {
            frmEsqueceuSenha tela = new frmEsqueceuSenha();
            tela.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblEspera_Click(object sender, EventArgs e)
        {

        }
    }
}
