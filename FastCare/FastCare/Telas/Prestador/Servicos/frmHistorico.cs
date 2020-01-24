using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastCare.Telas.Prestador.Servicos
{
    public partial class frmHistorico : Form
    {
        public frmHistorico()
        {
            InitializeComponent();

            Business.ServicosBusiness busprest = new Business.ServicosBusiness();
            List<Model.Entities.tb_servico> list = busprest.ListarServicos(Model.Entities.Prestador.id);

            dgvPrestador.DataSource = list;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
