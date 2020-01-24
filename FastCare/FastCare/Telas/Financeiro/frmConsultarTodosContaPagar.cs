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
    public partial class frmConsultarTodosContaPagar : Form
    {
        public frmConsultarTodosContaPagar()
        {
            InitializeComponent();
        }

        private void cboOrdem_SelectedIndexChanged(object sender, EventArgs e)
        {
            Business.DespesaBusiness busconta = new Business.DespesaBusiness();

            string ordem = cboOrdem.Text;

            List<Model.Entities.tb_conta> conta = busconta.ListarDespesaPorOrdem(ordem);
            dgvFinanceiro.DataSource = conta;
        }

        private void ImgBack_Click(object sender, EventArgs e)
        {
            Telas.Outros.frmMenuGerente tela = new Outros.frmMenuGerente();
            tela.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
