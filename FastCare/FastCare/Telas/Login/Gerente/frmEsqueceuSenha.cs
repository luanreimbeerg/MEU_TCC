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
    public partial class frmEsqueceuSenha : Form
    {
        public frmEsqueceuSenha()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Utils.GeradorDeCodigos gerador = new Utils.GeradorDeCodigos();
            APIs.ApiGmailSender gmail = new APIs.ApiGmailSender();
            string codigo = gerador.GerarCodigo();

            string para = txtEmail.Text;
            string assunto = "Recuperação de senha Fast Care";
            string mensagem = "O seu código de verificação é " + codigo;

            gmail.Enviar(para, assunto, mensagem);

            Model.Entities.UsuarioLogado.email = txtEmail.Text;
            Model.Entities.UsuarioLogado.chave = codigo;

            MessageBox.Show("O código foi enviado com sucesso", "Fast Care", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmRecuperarSenha tela = new frmRecuperarSenha();
            tela.Show();
            Hide();
        }

        private void ImgBack_Click(object sender, EventArgs e)
        {
            frmLogin tela = new frmLogin();
            tela.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(196, 231, 167);
            button2.ForeColor = Color.Black;
        }

        private void ImgBack_MouseEnter(object sender, EventArgs e)
        {
            ImgBack.BackColor = Color.White;
        }

        private void ImgBack_MouseLeave(object sender, EventArgs e)
        {
            ImgBack.BackColor = Color.FromArgb(196, 231, 167);
        }
    }
}
