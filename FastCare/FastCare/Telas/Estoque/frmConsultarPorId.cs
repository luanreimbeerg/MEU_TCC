using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastCare.Telas.Estoque
{
    public partial class frmConsultarPorId : Form
    {
        public frmConsultarPorId()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Telas.Outros.frmMenuGerente tela = new Outros.frmMenuGerente();
            tela.Show();
            Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nudID_ValueChanged_1(object sender, EventArgs e)
        {
            dgvEstoque.AutoGenerateColumns = false;
            int id = Convert.ToInt32(nudID.Value);

            Business.EstoqueBusiness busestock = new Business.EstoqueBusiness();
            List<Model.Entities.tb_estoque> lista = busestock.ListarPorID(id);

            dgvEstoque.DataSource = lista;
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            Button1.BackColor = Color.Red;
            Button1.ForeColor = Color.White;
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            Button1.BackColor = Color.FromArgb(196, 231, 167);
            Button1.ForeColor = Color.Black;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            ImgBac.BackColor = Color.White;
        }

        private void ImgBac_MouseLeave(object sender, EventArgs e)
        {
            ImgBac.BackColor = Color.FromArgb(196, 231, 167);
        }

        private void nudID_ValueChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(nudID.Value);
            dgvEstoque.AutoGenerateColumns = false;

            Business.EstoqueBusiness estoque = new Business.EstoqueBusiness();
            List<Model.Entities.tb_estoque> lista = estoque.ListarPorID(id);

            dgvEstoque.DataSource = lista;
        }
    }
}
