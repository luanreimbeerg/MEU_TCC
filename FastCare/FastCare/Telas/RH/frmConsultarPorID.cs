using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastCare.Telas.RH
{
    public partial class frmConsultarPorID : Form
    {
        public frmConsultarPorID()
        {
            InitializeComponent();
        }

        private void nudId_ValueChanged(object sender, EventArgs e)
        {
            dgvFuncionario.AutoGenerateColumns = false;
            int id = Convert.ToInt32(nudId.Value);

            Business.RHBusiness rh = new Business.RHBusiness();
            List<Model.Entities.tb_funcionario> lista = rh.ListarPorID(id);

            dgvFuncionario.DataSource = lista;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Outros.frmMenuGerente tela = new Outros.frmMenuGerente();
            tela.Show();
            Hide();
        }
    }
}
