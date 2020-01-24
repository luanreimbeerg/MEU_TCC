using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastCare.Telas.Estoque
{
    public partial class frmAlterarEstoque : Form
    {
        public frmAlterarEstoque()
        {
            InitializeComponent();

            Business.EstoqueBusiness busestoque = new Business.EstoqueBusiness();
            List<Model.Entities.tb_estoque> list = busestoque.ListarPorTodos();

            cboProduto.DisplayMember = nameof(Model.Entities.tb_estoque.nm_produto);
            cboProduto.DataSource = list;
        }

        private void cboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.Entities.tb_estoque estock = cboProduto.SelectedItem as Model.Entities.tb_estoque;
            nudQuantidade.Value = Convert.ToDecimal(estock.qt_produtos);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Entities.tb_estoque estock = cboProduto.SelectedItem as Model.Entities.tb_estoque;
                Model.Entities.tb_estoque alterar = new Model.Entities.tb_estoque();

                alterar.id_estoque = estock.id_estoque;
                alterar.qt_produtos = Convert.ToInt32(nudQuantidade.Value);
                alterar.id_suprimento = estock.id_suprimento;

                Business.EstoqueBusiness busestoque = new Business.EstoqueBusiness();
                busestoque.Alterar(alterar);

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

        private void frmAlterarEstoque_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ImgBack_Click(object sender, EventArgs e)
        {
            Telas.Outros.frmMenuGerente tela = new Outros.frmMenuGerente();
            tela.Show();
            Hide();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.White;
        }

        private void ImgBack_MouseEnter(object sender, EventArgs e)
        {
            ImgBack.BackColor = Color.White;
        }

        private void ImgBack_MouseLeave(object sender, EventArgs e)
        {
            ImgBack.ForeColor = Color.FromArgb(196, 231, 167);
        }
    }
}
