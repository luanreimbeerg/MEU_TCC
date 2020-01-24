using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastCare.Telas.Login.Cliente
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

        private void lblCadastreSe_Click(object sender, EventArgs e)
        {
            frmCadastrar tela = new frmCadastrar();
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
                logg.VerificarUsuarioCliente(log);

                Outros.frmMenuCliente tela = new Outros.frmMenuCliente();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ImgBack_Click_1(object sender, EventArgs e)
        {
            Outros.frmLogar tela = new Outros.frmLogar();
            tela.Show();
            Hide();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
