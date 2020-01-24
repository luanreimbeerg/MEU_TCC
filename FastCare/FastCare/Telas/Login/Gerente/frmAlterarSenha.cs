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
    public partial class frmAlterarSenha : Form
    {
        public frmAlterarSenha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model.Entities.tb_login login = new Model.Entities.tb_login();

            login.ds_senha = txtNovaSenha.Text;
            login.nm_email = Model.Entities.UsuarioLogado.email;

            string confirmacao = txtConfirmaSenha.Text;

            if (login.ds_senha == confirmacao)
            {
                Business.LoginBusiness alterar = new Business.LoginBusiness();
                alterar.AlterarSenha(login);
            }
            else
                MessageBox.Show("A senha não estão iguais", "Fast Care", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageBox.Show("Senha alterada com sucesso", "Fast Care", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmLogin tela = new frmLogin();
            tela.Show();
            Hide();
        }

        private void txtNovaSenha_TextChanged(object sender, EventArgs e)
        {
            string senha = txtNovaSenha.Text;

            string forca = Utils.Validacao.ValidarSenha(senha);

            if (forca == "Senha Fraca")
            {
                lblForca.ForeColor = Color.Red;
                lblForca.Text = forca;
                lblForca.Visible = true;
            }

            else if (senha.Length == 0)
                lblForca.Visible = false;

            else if (forca == "Senha Média")
            {
                lblForca.ForeColor = Color.Yellow;
                lblForca.Text = forca;
                lblForca.Visible = true;
            }

            else if (forca == "Senha Forte")
            {
                lblForca.ForeColor = Color.Green;
                lblForca.Text = forca;
                lblForca.Visible = true;
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ImgBack_Click(object sender, EventArgs e)
        {
            frmRecuperarSenha tela = new frmRecuperarSenha();
            tela.Show();
            Hide();
        }
    }
}
