using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastCare.Telas.Cliente.Servico
{
    public partial class frmNovoServico : Form
    {
        public frmNovoServico()
        {
            InitializeComponent();

            dgvPedido.AutoGenerateColumns = false;

            Business.PrestadorBusiness pres = new Business.PrestadorBusiness();
            pres.ListarPorTodos();

            dgvPedido.DataSource = pres;

        }

        private void ImgBack_Click(object sender, EventArgs e)
        {
            Outros.frmMenuGerente tela = new Outros.frmMenuGerente();
            tela.Show();
            Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
