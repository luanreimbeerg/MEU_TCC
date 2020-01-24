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
    public partial class frmRemoverEstoque : Form
    {
        public frmRemoverEstoque()
        {
            InitializeComponent();

            ConsultarProdutos();
        }
        
        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Entities.tb_estoque estoque = cboProduto.SelectedItem as Model.Entities.tb_estoque;

                Business.EstoqueBusiness busestoque = new Business.EstoqueBusiness();
                busestoque.Remover(estoque.id_estoque);

                MessageBox.Show("Remoção efetuada com sucesso", "Fast Care", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ConsultarProdutos();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Outros.frmMenuGerente tela = new Outros.frmMenuGerente();
            tela.Show();
            Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button1.BackColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(196, 231, 167);
            button1.BackColor = Color.Black;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            ImgBack.BackColor = Color.White;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            ImgBack.BackColor = Color.FromArgb(196, 231, 167);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.Entities.tb_estoque estock = cboProduto.SelectedItem as Model.Entities.tb_estoque;
            nudQuantidade.Value = Convert.ToDecimal(estock.qt_produtos);
        }

        private void ConsultarProdutos()
        {
            Business.EstoqueBusiness busestoque = new Business.EstoqueBusiness();
            List<Model.Entities.tb_estoque> list = busestoque.ListarPorTodos();

            cboProduto.DisplayMember = nameof(Model.Entities.tb_estoque.nm_produto);
            cboProduto.DataSource = list;
        }
    }
}
