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
    public partial class frmCadastrar : Form
    {
        public frmCadastrar()
        {
            InitializeComponent();
        }

        private void imgBack_Click(object sender, EventArgs e)
        {
            Outros.frmCadastrarUsuario tela = new Outros.frmCadastrarUsuario();
            tela.Show();
            Hide();
        }

        private void imgClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Entities.tb_login log = new Model.Entities.tb_login();
                log.ds_senha = txtSenha.Text;
                log.nm_email = txtEmail.Text;
                log.nm_usuario = txtUsuário.Text;
                log.ds_tipo = "Prestador";

                Business.LoginBusiness logg = new Business.LoginBusiness();
                logg.VerificarSeExistePrestador(log);
                logg.Inserir(log);

                MessageBox.Show("Usuario Cadastrado Com Sucesso");
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Outros.frmCadastrarUsuario tela = new Outros.frmCadastrarUsuario();
            tela.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
