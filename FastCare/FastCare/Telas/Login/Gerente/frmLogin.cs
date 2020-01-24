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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
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
                logg.VerificarUsuarioGerente(log);

                Outros.frmMenuGerente tela = new Outros.frmMenuGerente();
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

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.White;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.FromArgb(196, 231, 167);
        }
    }
}
