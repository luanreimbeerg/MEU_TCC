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
    public partial class frmMenuCliente : Form
    {
        public frmMenuCliente()
        {
            InitializeComponent();
        }

        private void imgBaby_Click(object sender, EventArgs e)
        {
            Cliente.Servico.frmNovoServico tela = new Cliente.Servico.frmNovoServico();
            tela.Show();
            Hide();
        }

        private void imgClean_Click(object sender, EventArgs e)
        {
            
        }

        private void imgVoltar_Click(object sender, EventArgs e)
        {
            frmLogar tela = new frmLogar();
            tela.Show();
            Hide();
        }

        private void imgFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgFechar_MouseEnter(object sender, EventArgs e)
        {
            imgFechar.BackColor = Color.Red;
            imgFechar.ForeColor = Color.White;
        }

        private void imgFechar_MouseLeave(object sender, EventArgs e)
        {
            imgFechar.BackColor = Color.FromArgb(196, 231, 167);
            imgFechar.ForeColor = Color.Black;
        }

        private void imgVoltar_MouseEnter(object sender, EventArgs e)
        {
            imgVoltar.BackColor = Color.White;
        }

        private void imgVoltar_MouseLeave(object sender, EventArgs e)
        {
            imgVoltar.BackColor = Color.FromArgb(196, 231, 167);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
