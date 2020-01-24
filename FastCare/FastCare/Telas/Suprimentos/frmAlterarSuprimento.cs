using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastCare.Telas.Suprimentos
{
    public partial class frmAlterarSuprimento : Form
    {
        public frmAlterarSuprimento()
        {
            InitializeComponent();
            Business.FonecedorBusiness busforn = new Business.FonecedorBusiness();
            Business.SuprimentosBusiness bussupri = new Business.SuprimentosBusiness();
            List<Model.Entities.tb_suprimento> supri = bussupri.ListarPorTodos();
            List<Model.Entities.tb_fornecedor> lista = busforn.ListarPorTodos();

            cboFornecedor.DisplayMember = nameof(Model.Entities.tb_fornecedor.nm_forn);
            cboFornecedor.DataSource = lista;
            cboProduto.DisplayMember = nameof(Model.Entities.tb_suprimento.nm_produto);
            cboProduto.DataSource = supri;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //try
            //{
                Model.Entities.tb_suprimento supri = cboProduto.SelectedItem as Model.Entities.tb_suprimento;
                Model.Entities.tb_fornecedor forn = cboFornecedor.SelectedItem as Model.Entities.tb_fornecedor;

                supri.id_fornecedor = forn.id_fornecedor;
                supri.nm_produto = txtProduto.Text;
                supri.qt_produtos = Convert.ToInt32(nudQtdProduto.Value);
                supri.vl_preco = nudPreco.Value;

                Business.SuprimentosBusiness bussupri = new Business.SuprimentosBusiness();
                bussupri.Alterar(supri);

                MessageBox.Show("Alteração efetuada com sucesso", "Fast Care", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (ArgumentException ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Ocorreu um erro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ImgBack_Click_1(object sender, EventArgs e)
        {
            Outros.frmMenuGerente tela = new Outros.frmMenuGerente();
            tela.Show();
            Hide();
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            Button1.BackColor = Color.Red;
            Button1.ForeColor = Color.Black;
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            Button1.BackColor = Color.FromArgb(34, 163, 98);
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

        private void btnAlterar_MouseEnter(object sender, EventArgs e)
        {
            btnAlterar.BackColor = Color.LawnGreen;
            btnAlterar.ForeColor = Color.White;
            Point pt = new Point(193, 381);
            btnAlterar.Height = 43;
            btnAlterar.Width = 109;
            btnAlterar.Location = pt;
        }

        private void btnAlterar_MouseLeave(object sender, EventArgs e)
        {
            btnAlterar.BackColor = Color.White;
            btnAlterar.ForeColor = Color.FromArgb(245, 177, 10);
            Point pt = new Point(198, 386);
            btnAlterar.Height = 33;
            btnAlterar.Width = 99;
            btnAlterar.Location = pt;
        }

        private void cboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.Entities.tb_suprimento supri = cboProduto.SelectedItem as Model.Entities.tb_suprimento;
            int id = supri.id_suprimento;

            Business.SuprimentosBusiness bussupri = new Business.SuprimentosBusiness();
            Model.Entities.tb_suprimento dados = bussupri.ListarPorIdModelo(id);

            if (dados == null)
            {
                cboFornecedor.Text = string.Empty;
                txtProduto.Text = string.Empty;
                nudQtdProduto.Value = 0;
                nudPreco.Value = 0;
            }
            else
            {
                cboFornecedor.Text = dados.tb_fornecedor.nm_forn;
                txtProduto.Text = dados.nm_produto;
                nudQtdProduto.Value = Convert.ToDecimal(dados.qt_produtos);
                nudPreco.Value = Convert.ToDecimal(dados.vl_preco);
            }
        }
    }
}
