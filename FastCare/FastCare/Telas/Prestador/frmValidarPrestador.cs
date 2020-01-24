using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastCare.Telas.Prestador
{
    public partial class frmValidarPrestador : Form
    {
        public frmValidarPrestador()
        {
            InitializeComponent();
            dgvPonto.AutoGenerateColumns = false;

            Business.PrestadorBusiness buspres = new Business.PrestadorBusiness();

            List<Model.Entities.tb_prestador> list = buspres.ListarPorTodosInativos();
            dgvPonto.DataSource = list;
        }

        private void dgvPonto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 14)
            {
                Model.Entities.Prestador.cel = dgvPonto.CurrentRow.Cells[9].Value.ToString();
                Model.Entities.Prestador.cep = dgvPonto.CurrentRow.Cells[4].Value.ToString();
                Model.Entities.Prestador.cpf = dgvPonto.CurrentRow.Cells[3].Value.ToString();
                Model.Entities.Prestador.dt_nasc = Convert.ToDateTime(dgvPonto.CurrentRow.Cells[13].Value);
                Model.Entities.Prestador.email = dgvPonto.CurrentRow.Cells[10].Value.ToString();
                Model.Entities.Prestador.endereco = dgvPonto.CurrentRow.Cells[5].Value.ToString();
                Model.Entities.Prestador.genero = dgvPonto.CurrentRow.Cells[12].Value.ToString();
                Model.Entities.Prestador.id = Convert.ToInt32(dgvPonto.CurrentRow.Cells[0].Value);
                Model.Entities.Prestador.nome = dgvPonto.CurrentRow.Cells[1].Value.ToString();
                Model.Entities.Prestador.numero = dgvPonto.CurrentRow.Cells[6].Value.ToString();
                Model.Entities.Prestador.rg = dgvPonto.CurrentRow.Cells[2].Value.ToString();
                Model.Entities.Prestador.setor = dgvPonto.CurrentRow.Cells[11].Value.ToString();
                Model.Entities.Prestador.uf = dgvPonto.CurrentRow.Cells[7].Value.ToString();
                Model.Entities.Prestador.tel = dgvPonto.CurrentRow.Cells[8].Value.ToString();

                frmAceitarRejeitar tela = new Prestador.frmAceitarRejeitar();
                tela.Show();
                Hide();
            }

            if (e.ColumnIndex == 15)
            {

            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Outros.frmMenuGerente tela = new Outros.frmMenuGerente();
            tela.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
