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
    public partial class frmCadastrarEstoque : Form
    {
        public frmCadastrarEstoque()
        {
            InitializeComponent();
            Business.SuprimentosBusiness bussupri = new Business.SuprimentosBusiness();
            List<string> lista = bussupri.ListarPorTodosDistinct();

            cboProduto.DataSource = lista;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string produto = cboProduto.Text;
                int idsupri = 0;

                Model.Entities.tb_estoque estoque = new Model.Entities.tb_estoque();

                Business.EstoqueBusiness busestoque = new Business.EstoqueBusiness();
                Business.SuprimentosBusiness bussupri = new Business.SuprimentosBusiness();

                Model.Entities.tb_estoque existente = busestoque.ListarPorProduto(produto);
                List<Model.Entities.tb_suprimento> supri = bussupri.ListarPorProdutoDecrescente(produto);

                foreach (Model.Entities.tb_suprimento t in supri)
                {
                    if (t.nm_produto == produto)
                    {
                        idsupri = t.id_suprimento;
                        break;
                    }
                }

                estoque.id_suprimento = idsupri;
                estoque.qt_produtos = Convert.ToInt32(nudQuantidade.Value);

                if (existente == null)
                {
                    busestoque.Inserir(estoque);
                    MessageBox.Show("Cadastro efetuado com sucesso", "Fast Care", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    estoque.id_estoque = existente.id_estoque;
                    busestoque.Alterar(estoque);
                    MessageBox.Show("Adicionado ao estoque com sucesso", "Fast Care", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        private void cboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ImgBack_Click(object sender, EventArgs e)
        {
            Telas.Outros.frmMenuGerente telas = new Outros.frmMenuGerente();
            telas.Show();
            Hide();
        }

        private void cboProduto_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string produto = cboProduto.Text;
            int quantidade = 0;
            int idsupri = 0;

            Business.SuprimentosBusiness bussupri = new Business.SuprimentosBusiness();
            Business.EstoqueBusiness busestoque = new Business.EstoqueBusiness();

            List<Model.Entities.tb_suprimento> lista = bussupri.ListarPorProdutoDecrescente(produto);
            Model.Entities.tb_estoque estoque = busestoque.ListarPorProduto(produto);

            foreach (Model.Entities.tb_suprimento t in lista)
            {
                if (t.nm_produto == produto)
                {
                    quantidade = t.qt_produtos;
                    idsupri = t.id_suprimento;
                    break;
                }
            }

            if (estoque == null)
                nudQuantidade.Value = quantidade;

            else if (estoque != null && estoque.id_suprimento != idsupri)
                nudQuantidade.Value = Convert.ToInt32(quantidade + estoque.qt_produtos);

            else if (estoque != null && estoque.id_suprimento == idsupri)
                nudQuantidade.Value = Convert.ToInt32(estoque.qt_produtos);
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
            ImgBack.BackColor = Color.FromArgb(196, 231, 167);
        }
    }
}
