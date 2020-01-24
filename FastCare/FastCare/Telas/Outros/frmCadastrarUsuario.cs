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
    public partial class frmCadastrarUsuario : Form
    {
        public frmCadastrarUsuario()
        {
            InitializeComponent();
        }

       
        private void imgFuncionario_Click(object sender, EventArgs e)
        {
            Login.Funcionario.frmCadastrar tela = new Login.Funcionario.frmCadastrar();
            tela.Show();
            Hide();
        }

        private void lblFuncionario_Click(object sender, EventArgs e)
        {
            Login.Funcionario.frmCadastrar tela = new Login.Funcionario.frmCadastrar();
            tela.Show();
            Hide();
        }

        private void imgCliente_Click(object sender, EventArgs e)
        {
            Login.Cliente.frmCadastrar tela = new Login.Cliente.frmCadastrar();
            tela.Show();
            Hide();
        }

        private void lblCliente_Click(object sender, EventArgs e)
        {
            Login.Cliente.frmCadastrar tela = new Login.Cliente.frmCadastrar();
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

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.White;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.FromArgb(196, 231, 167);
        }
    }
}
