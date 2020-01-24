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
    public partial class frmAlterarFornecedor : Form
    {
        public frmAlterarFornecedor()
        {
            InitializeComponent();

            Business.FonecedorBusiness busforn = new Business.FonecedorBusiness();
            List<Model.Entities.tb_fornecedor> lista = busforn.ListarPorTodos();

            cboCnpj.DisplayMember = nameof(Model.Entities.tb_fornecedor.ds_cnpj);
            cboCnpj.DataSource = lista;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Entities.tb_fornecedor f = new Model.Entities.tb_fornecedor();

                f.nm_forn = txtFornecedor.Text;
                f.ds_cel = txtCel.Text;
                f.ds_cep = txtCep.Text;
                f.ds_cnpj = txtCnpj.Text;
                f.ds_email = txtEmail.Text;
                f.end_forn = txtEnd.Text;
                f.insc_estadual = txtInscrEstadual.Text;
                f.nu_forn = txtNCasa.Text;
                f.ds_tel = txtTel.Text;
                f.uf_estado = cboUF.Text;

                Business.FonecedorBusiness busf = new Business.FonecedorBusiness();

                if (f.ds_cnpj != Model.Entities.Fornecedor.cnpjantigo)
                    busf.Alterar(f);
                else
                    busf.AlterarCnpjIgual(f);

                MessageBox.Show("Alteração efetuada com sucesso", "Fast Care", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Telas.Outros.frmMenuGerente telas = new Outros.frmMenuGerente();
            telas.Show();
            Hide();
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

        private void ImgBack_MouseLeave(object sender, EventArgs e)
        {
            ImgBack.BackColor = Color.FromArgb(196, 231, 167);
            ImgBack.ForeColor = Color.Black;
        }

        private void btnCadastrar_MouseEnter(object sender, EventArgs e)
        {
            btnCadastrar.BackColor = Color.LawnGreen;
            btnCadastrar.ForeColor = Color.White;
            Point pt = new Point(590, 311);
            btnCadastrar.Height = 48;
            btnCadastrar.Width = 153;
            btnCadastrar.Location = pt;
        }

        private void btnCadastrar_MouseLeave(object sender, EventArgs e)
        {
            btnCadastrar.BackColor = Color.White;
            btnCadastrar.ForeColor = Color.FromArgb(245, 177, 10);
            Point pt = new Point(595, 316);
            btnCadastrar.Height = 38;
            btnCadastrar.Width = 143;
            btnCadastrar.Location = pt;
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

            Model.Entities.Fornecedor.cnpjantigo = txtCnpj.Text;
        }

        private void txtCep_TextChanged_1(object sender, EventArgs e)
        {
            if (txtCep.Text.Length == 9)
            {
                string cep = txtCep.Text;
                APIs.ApiCep cepp = new APIs.ApiCep();
                txtEnd.Text = cepp.Buscar(cep);
            }
            else
            {
                txtEnd.Text = string.Empty;
            }
        }
    }
}
