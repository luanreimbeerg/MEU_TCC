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
    public partial class frmConsultarPorTodos : Form
    {
        public frmConsultarPorTodos()
        {
            InitializeComponent();
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Telas.Outros.frmMenuGerente tela = new Outros.frmMenuGerente();
            tela.Show();
            Hide();
        }

        private void cboOrdem_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvEstoque.AutoGenerateColumns = false;
            string ordem = cboOrdem.Text;

            Business.EstoqueBusiness busE = new Business.EstoqueBusiness();
            List<Model.Entities.tb_estoque> lista = busE.ListarTodosPorOrdem(ordem);

            dgvEstoque.DataSource = lista;
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(196, 231, 167);
            button1.ForeColor = Color.Black;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            ImgBack.BackColor = Color.White;
        }

        private void ImgBack_MouseLeave(object sender, EventArgs e)
        {
            ImgBack.ForeColor = Color.FromArgb(196, 231, 167);
        }
    }
}
