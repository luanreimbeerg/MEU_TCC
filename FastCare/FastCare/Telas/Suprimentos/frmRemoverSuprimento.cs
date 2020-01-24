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
    public partial class frmRemoverSuprimento : Form
    {
        public frmRemoverSuprimento()
        {
            InitializeComponent();
            ConsultaDeProdutos();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Entities.tb_suprimento supri = cboProduto.SelectedItem as Model.Entities.tb_suprimento;
                int id = supri.id_suprimento;

                Business.SuprimentosBusiness bussupri = new Business.SuprimentosBusiness();
                bussupri.Remover(id);

                MessageBox.Show("Remoção efetuada com sucesso", "Fast Care", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cboFornecedor.Text = string.Empty;
                txtProduto.Text = string.Empty;
                nudQtdProduto.Value = 0;
                nudPreco.Value = 0;

                ConsultaDeProdutos();
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

        private void lblFechar_MouseEnter(object sender, EventArgs e)
        {
            Button1.BackColor = Color.Red;
            Button1.ForeColor = Color.White;
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            Button1.BackColor = Color.Transparent;
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

        private void btnRemover_MouseEnter(object sender, EventArgs e)
        {
            btnRemover.BackColor = Color.LawnGreen;
            btnRemover.ForeColor = Color.White;
            Point pt = new Point(194, 386);
            btnRemover.Height = 43;
            btnRemover.Width = 109;
            btnRemover.Location = pt;
        }

        private void btnRemover_MouseLeave(object sender, EventArgs e)
        {
            btnRemover.BackColor = Color.White;
            btnRemover.ForeColor = Color.FromArgb(245, 177, 10);
            Point pt = new Point(199, 391);
            btnRemover.Height = 33;
            btnRemover.Width = 99;
            btnRemover.Location = pt;
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

        private void cboProduto_SelectedIndexChanged_1(object sender, EventArgs e)
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
                nudPreco.Value = Convert.ToDecimal(supri.vl_preco);
            }
        }

        private void ConsultaDeProdutos()
        {
            Business.SuprimentosBusiness bussupri = new Business.SuprimentosBusiness();
            List<Model.Entities.tb_suprimento> supri = bussupri.ListarPorTodos();

            cboProduto.DisplayMember = nameof(Model.Entities.tb_suprimento.nm_produto);
            cboProduto.DataSource = supri;
            cboProduto.Text = string.Empty;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
