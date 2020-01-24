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
    public partial class frmSaidaDeEstoque : Form
    {
        public frmSaidaDeEstoque()
        {
            InitializeComponent();

            Business.EstoqueBusiness busestoque = new Business.EstoqueBusiness();
            List<Model.Entities.tb_estoque> list = busestoque.ListarPorTodos();

            cboProduto.DisplayMember = nameof(Model.Entities.tb_estoque.nm_produto);
            cboProduto.DataSource = list;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Entities.tb_estoque selecionado = cboProduto.SelectedItem as Model.Entities.tb_estoque;
                Model.Entities.tb_estoque estoque = new Model.Entities.tb_estoque();

                estoque.qt_produtos = selecionado.qt_produtos - Convert.ToInt32(nudRetirada.Value);
                estoque.id_estoque = selecionado.id_estoque;

                Business.EstoqueBusiness busestoque = new Business.EstoqueBusiness();
                busestoque.Alterar(estoque);

                MessageBox.Show("Retirada efetuada com sucesso", "Fast Care", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(196, 231, 167);
            button2.ForeColor = Color.Black;
        }

        private void ImgBack_MouseEnter(object sender, EventArgs e)
        {
            ImgBack.BackColor = Color.FromArgb(192, 255, 192);
        }

        private void ImgBack_MouseLeave(object sender, EventArgs e)
        {
            ImgBack.BackColor = Color.FromArgb(196, 231, 167);
        }
    }
}
