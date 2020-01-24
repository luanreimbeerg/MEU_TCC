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
    public partial class frmCadastrarSuprimentos : Form
    {
        public frmCadastrarSuprimentos()
        {
            InitializeComponent();
            Business.FonecedorBusiness busforn = new Business.FonecedorBusiness();
            List<Model.Entities.tb_fornecedor> lista = busforn.ListarPorTodos();

            cboFornecedor.DisplayMember = nameof(Model.Entities.tb_fornecedor.nm_forn);
            cboFornecedor.DataSource = lista;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Entities.tb_suprimento supri = new Model.Entities.tb_suprimento();
                Model.Entities.tb_fornecedor forn = cboFornecedor.SelectedItem as Model.Entities.tb_fornecedor;

                supri.id_fornecedor = forn.id_fornecedor;
                supri.nm_produto = txtProduto.Text.Trim();
                supri.qt_produtos = Convert.ToInt32(nudQtdProduto.Value);
                supri.vl_preco = nudPreco.Value;
                supri.dt_compra = dtpCompra.Value;

                Business.SuprimentosBusiness bussupri = new Business.SuprimentosBusiness();
                bussupri.Inserir(supri);

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
        

        private void imgFechar_MouseEnter(object sender, EventArgs e)
        {
            imgFechar.BackColor = Color.Red;
            imgFechar.ForeColor = Color.Black;
        }

        private void imgFechar_MouseLeave(object sender, EventArgs e)
        {
            imgFechar.BackColor = Color.Turquoise;
            imgFechar.ForeColor = Color.Black;
        }

        private void imgVoltar_Click_1(object sender, EventArgs e)
        {
            Outros.frmMenuGerente tela = new Outros.frmMenuGerente();
            tela.Show();
            Hide();
        }

        private void imgFechar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgVoltar_MouseEnter(object sender, EventArgs e)
        {
            imgVoltar.BackColor = Color.White;
            imgVoltar.ForeColor = Color.Black;
        }

        private void imgVoltar_MouseLeave(object sender, EventArgs e)
        {
            imgVoltar.BackColor = Color.FromArgb(196, 231, 167);
            imgVoltar.ForeColor = Color.Black;
        }

        private void btnCadastrar_MouseEnter(object sender, EventArgs e)
        {
            btnCadastrar.BackColor = Color.LawnGreen;
            btnCadastrar.ForeColor = Color.White;
            Point pt = new Point(211, 365);
            btnCadastrar.Height = 43;
            btnCadastrar.Width = 109;
            btnCadastrar.Location = pt;
        }

        private void btnCadastrar_MouseLeave(object sender, EventArgs e)
        {
            btnCadastrar.BackColor = Color.White;
            btnCadastrar.ForeColor = Color.FromArgb(245, 177, 10);
            Point pt = new Point(216, 370);
            btnCadastrar.Height = 33;
            btnCadastrar.Width = 99;
            btnCadastrar.Location = pt;
        }
    }
}
