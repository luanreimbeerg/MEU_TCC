using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastCare.Telas.Fornecedor
{
    public partial class frmRemoverFornecedor : Form
    {
        public frmRemoverFornecedor()
        {
            InitializeComponent();
            ConsultarCnpjs();
        }

        private void btnCadastrar_MouseEnter(object sender, EventArgs e)
        {
            btnRemover.BackColor = Color.LawnGreen;
            btnRemover.ForeColor = Color.White;
            Point pt = new Point(578, 387);
            btnRemover.Height = 48;
            btnRemover.Width = 153;
            btnRemover.Location = pt;
        }

        private void btnCadastrar_MouseLeave(object sender, EventArgs e)
        {
            btnRemover.BackColor = Color.White;
            btnRemover.ForeColor = Color.FromArgb(245, 177, 10);
            Point pt = new Point(583, 392);
            btnRemover.Height = 38;
            btnRemover.Width = 143;
            btnRemover.Location = pt;
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

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            ImgBack.BackColor = Color.White;
            ImgBack.ForeColor = Color.Black;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            ImgBack.BackColor = Color.FromArgb(196, 231, 167);
            ImgBack.ForeColor = Color.Black;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ImgBack_Click(object sender, EventArgs e)
        {
            Telas.Outros.frmMenuGerente telas = new Outros.frmMenuGerente();
            telas.Show();
            Hide();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Entities.tb_fornecedor forn = cboCnpj.SelectedItem as Model.Entities.tb_fornecedor;

                Business.FonecedorBusiness busf = new Business.FonecedorBusiness();
                busf.Remover(forn.id_fornecedor);

                MessageBox.Show("Remoção efetuada com sucesso", "Fast Care", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ConsultarCnpjs();

                txtFornecedor.Clear();
                txtCel.Clear();
                txtCep.Clear();
                txtCnpj.Clear();
                txtEmail.Clear();
                txtEnd.Clear();
                txtInscrEstadual.Clear();
                txtNCasa.Clear();
                cboUF.Text = string.Empty;

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboCnpj_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Model.Entities.tb_fornecedor f = cboCnpj.SelectedItem as Model.Entities.tb_fornecedor;

            txtFornecedor.Text = f.nm_forn;
            txtCel.Text = f.ds_cel;
            txtCep.Text = f.ds_cep;
            txtCnpj.Text = f.ds_cnpj;
            txtEmail.Text = f.ds_email;
            txtEnd.Text = f.end_forn;
            txtInscrEstadual.Text = f.insc_estadual;
            txtNCasa.Text = f.nu_forn;
            txtTel.Text = f.ds_tel;
            cboUF.Text = f.uf_estado;
        }

        private void ConsultarCnpjs()
        {
            Business.FonecedorBusiness busforn = new Business.FonecedorBusiness();
            List<Model.Entities.tb_fornecedor> lista = busforn.ListarPorTodos();

            cboCnpj.DisplayMember = nameof(Model.Entities.tb_fornecedor.ds_cnpj);
            cboCnpj.DataSource = lista;
        }

        private void frmRemoverFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}

