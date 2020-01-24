using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastCare.Telas.Cartao_Ponto
{
    public partial class frmBaterPonto : Form
    {
        public frmBaterPonto()
        {
            InitializeComponent();

            lblData.Text = "Data de ponto: " + DateTime.Now.Date;
        }

        private void txtID_KeyUp(object sender, KeyEventArgs e)
        {
            dgvPonto.AutoGenerateColumns = false;
            if(e.KeyCode == Keys.Enter)
            {
                int id = Convert.ToInt32(txtID.Text);

                Business.RHBusiness busrh = new Business.RHBusiness();
                Business.PontoBusiness busponto = new Business.PontoBusiness();

                Model.Entities.tb_car_ponto ponto = new Model.Entities.tb_car_ponto();
                Model.Entities.tb_funcionario func = busrh.ListarFunciinario(id);

                lblNome.Text = "Nome: " + func.nm_funcionario;

                ponto.id_funcionario = func.id_funcionario;
                ponto.dt_dia = DateTime.Now.Date;
                ponto.hr_almoco = DateTime.Now.TimeOfDay;
                ponto.hr_entrada = DateTime.Now.TimeOfDay;
                ponto.hr_saida = DateTime.Now.TimeOfDay;
                ponto.hr_saidaextra = DateTime.Now.TimeOfDay;
                ponto.hr_extra = DateTime.Now.TimeOfDay;
                ponto.hr_volta = DateTime.Now.TimeOfDay;

                Model.Entities.tb_car_ponto model = busponto.AdicionarPonto(ponto);
                List<Model.Entities.tb_car_ponto> list = busponto.ListarPonto(id);

                dgvPonto.DataSource = list;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ImgBack_Click(object sender, EventArgs e)
        {
            Outros.frmMenuGerente tela = new Outros.frmMenuGerente();
            tela.Show();
            Hide();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(196, 231, 167);
            button2.ForeColor = Color.Black;
        }

        private void ImgBack_MouseEnter(object sender, EventArgs e)
        {
            ImgBack.BackColor = Color.White;
        }

        private void ImgBack_MouseLeave(object sender, EventArgs e)
        {
            ImgBack.ForeColor = Color.FromArgb(196, 231, 167);
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
