using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastCare.Telas.Login.Funcionario
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblEsqueceuSenha_Click(object sender, EventArgs e)
        {
            frmEsqueceuSenha tela = new frmEsqueceuSenha();
            tela.Show();
            Hide();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Entities.tb_login log = new Model.Entities.tb_login();
                log.nm_email = txtEmail.Text;
                log.ds_senha = txtSenha.Text;

                Business.LoginBusiness logg = new Business.LoginBusiness();
                logg.VerificarUsuarioPrestador(log);

                Outros.frmMenuPrestador tela = new Outros.frmMenuPrestador();
                tela.Show();
                Hide();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblCadastreSe_Click(object sender, EventArgs e)
        {
            Outros.frmCadastrarPrestador tela = new Outros.frmCadastrarPrestador();
            tela.Show();
            Hide();
        }

        private void ImgBack_Click(object sender, EventArgs e)
        {
            Outros.frmLogar tela = new Outros.frmLogar();
            tela.Show();
            Hide();
        }

        private void imgClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Outros.frmLogar tela = new Outros.frmLogar();
            tela.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
