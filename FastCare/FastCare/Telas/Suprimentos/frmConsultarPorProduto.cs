using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastCare.Telas.Suprimentos
{
    public partial class frmConsultarPorProduto : Form
    {
        public frmConsultarPorProduto()
        {
            InitializeComponent();
            dgvSuprimento.AutoGenerateColumns = false;
        }
        
        private void ImgBack_Click(object sender, EventArgs e)
        {
            Outros.frmMenuGerente tela = new Outros.frmMenuGerente();
            tela.Show();
            Hide();
        }

        private void imgClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            Button1.BackColor = Color.Red;
            Button1.ForeColor = Color.Black;
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            Button1.BackColor = Color.FromArgb(196, 231, 167);
            Button1.ForeColor = Color.Black;
        }

        private void ImgBack_MouseEnter(object sender, EventArgs e)
        {
            ImgBack.BackColor = Color.White;
            ImgBack.ForeColor = Color.Black;
        }

        private void ImgBack_MouseLeave(object sender, EventArgs e)
        {
            ImgBack.BackColor = Color.FromArgb(196, 231, 167);
            ImgBack.ForeColor = Color.Black;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ImgBack_Click_1(object sender, EventArgs e)
        {
            Outros.frmMenuGerente tela = new Outros.frmMenuGerente();
            tela.Show();
            Hide();
        }

        private void txtProduto_TextChanged_1(object sender, EventArgs e)
        {
            dgvSuprimento.AutoGenerateColumns = false;
            string produto = txtProduto.Text.Trim();

            Business.SuprimentosBusiness bussupri = new Business.SuprimentosBusiness();
            List<Model.Entities.tb_suprimento> supri = bussupri.ListarPorProduto(produto);

            dgvSuprimento.DataSource = supri;
        }
    }
}
