using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastCare.Telas.Financeiro
{
    public partial class frmFluxoDeCaixa : Form
    {
        public frmFluxoDeCaixa()
        {
            InitializeComponent();
        }

        private void dtpFluxoPesquisa_ValueChanged(object sender, EventArgs e)
        {
            ConsultaDeFluxo();
        }


        private void dtpFinal_ValueChanged(object sender, EventArgs e)
        {
            ConsultaDeFluxo();
        }

        private void ConsultaDeFluxo()
        {
            dgvFluxo.AutoGenerateColumns = false;
            DateTime datainicio = Convert.ToDateTime(dtpInicio.Value);
            DateTime datafim = Convert.ToDateTime(dtpFinal.Value);

            Business.FinanceirosBusiness busfinanc = new Business.FinanceirosBusiness();
            List<Model.Entities.vw_fluxo_caixa> fluxo = busfinanc.ListarPorFluxo(datainicio, datafim);

            dgvFluxo.DataSource = fluxo;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Outros.frmMenuGerente tela = new Outros.frmMenuGerente();
            tela.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.Black;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.ForeColor = Color.Transparent;
        }
    }
}
