using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastCare.Telas.Outros
{
    public partial class frmLogar : Form
    {
        public frmLogar()
        {
            InitializeComponent();
        }

        private void imgGerente_Click(object sender, EventArgs e)
        {
            Login.Gerente.frmLogin tela = new Login.Gerente.frmLogin();
            tela.Show();
            Hide();
        }

        private void lblGerente_Click(object sender, EventArgs e)
        {
            Login.Gerente.frmLogin tela = new Login.Gerente.frmLogin();
            tela.Show();
            Hide();
        }

        private void imgFuncionario_Click(object sender, EventArgs e)
        {
            Login.Funcionario.frmLogin tela = new Login.Funcionario.frmLogin();
            tela.Show();
            Hide();
        }

        private void lblFuncionario_Click(object sender, EventArgs e)
        {
            Login.Funcionario.frmLogin tela = new Login.Funcionario.frmLogin();
            tela.Show();
            Hide();
        }

        private void imgCliente_Click(object sender, EventArgs e)
        {
            Login.Cliente.frmLogin tela = new Login.Cliente.frmLogin();
            tela.Show();
            Hide();
        }

        private void lblCliente_Click(object sender, EventArgs e)
        {
            Login.Cliente.frmLogin tela = new Login.Cliente.frmLogin();
            tela.Show();
            Hide();
        }

        private void imgClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ImgBack_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
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
    }
}
