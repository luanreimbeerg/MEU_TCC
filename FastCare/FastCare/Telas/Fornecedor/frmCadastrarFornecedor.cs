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
    public partial class frmCadastrarFornecedor : Form
    {
        public frmCadastrarFornecedor()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Entities.tb_fornecedor forn = new Model.Entities.tb_fornecedor();

                forn.ds_cel = txtCel.Text;
                forn.ds_cep = txtCep.Text;
                forn.ds_cnpj = txtCnpj.Text;
                forn.ds_email = txtEmail.Text.Trim();
                forn.ds_tel = txtTel.Text;
                forn.end_forn = txtEnd.Text;
                forn.insc_estadual = txtInscrEstadual.Text.Trim();
                forn.nm_forn = txtFornecedor.Text.Trim();
                forn.nu_forn = txtNCasa.Text.Trim();
                forn.uf_estado = cboUF.Text;

                Business.FonecedorBusiness busforn = new Business.FonecedorBusiness();
                busforn.Inserir(forn);

                MessageBox.Show("Cadastro efetuado com sucesso", "Fast Care", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ImgBack_Click(object sender, EventArgs e)
        {
            Outros.frmMenuGerente tela = new Outros.frmMenuGerente();
            tela.Show();
            Hide();
        }

        private void imgClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_MouseEnter(object sender, EventArgs e)
        {
            btnCadastrar.BackColor = Color.LawnGreen;
            btnCadastrar.ForeColor = Color.White;
            Point pt = new Point(591, 280);
            btnCadastrar.Height = 48;
            btnCadastrar.Width = 153;
            btnCadastrar.Location = pt;
        }

        private void btnCadastrar_MouseLeave(object sender, EventArgs e)
        {
            btnCadastrar.BackColor = Color.White;
            btnCadastrar.ForeColor = Color.FromArgb(245, 177, 10);
            Point pt = new Point(596, 285);
            btnCadastrar.Height = 38;
            btnCadastrar.Width = 143;
            btnCadastrar.Location = pt;
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

        private void ImgBack_MouseEnter(object sender, EventArgs e)
        {
            ImgBack.BackColor = Color.White;
            ImgBack.ForeColor = Color.Black;
        }

        private void ImgBack_MouseLeave(object sender, EventArgs e)
        {
            ImgBack.BackColor = Color.FromArgb(196, 231, 167);
            ImgBack.ForeColor = Color.Black;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ImgBack_Click_1(object sender, EventArgs e)
        {
            Telas.Outros.frmMenuGerente telas = new Outros.frmMenuGerente();
            telas.Show();
            Hide();
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
