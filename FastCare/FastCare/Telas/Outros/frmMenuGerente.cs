using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastCare.Telas.Outros
{
    public partial class frmMenuGerente : Form
    {
        public frmMenuGerente()
        {
            InitializeComponent();

            lblBemVindo.Text = "Bem-Vindo " + Model.Entities.UsuarioLogado.usuario;
            lblNome.Text = "Nome: " + Model.Entities.UsuarioLogado.usuario;

            if (Model.Entities.UsuarioLogado.imagem != null)
            {
                Utils.ConversorImagem convert = new Utils.ConversorImagem();
                imgGerente.Image = convert.ConverterParaImagem(Model.Entities.UsuarioLogado.imagem);
            }

            HorarioEmSessao();
        }

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Suprimentos.frmCadastrarSuprimentos tela = new Suprimentos.frmCadastrarSuprimentos();
            tela.Show();
            Hide();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suprimentos.frmAlterarSuprimento tela = new Suprimentos.frmAlterarSuprimento();
            tela.Show();
            Hide();
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suprimentos.frmRemoverSuprimento tela = new Suprimentos.frmRemoverSuprimento();
            tela.Show();
            Hide();
        }

        private void porIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suprimentos.frmConsultarPorID tela = new Suprimentos.frmConsultarPorID();
            tela.Show();
            Hide();
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suprimentos.frmConsultarTodos tela = new Suprimentos.frmConsultarTodos();
            tela.Show();
            Hide();
        }

        private void porProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suprimentos.frmConsultarPorProduto tela = new Suprimentos.frmConsultarPorProduto();
            tela.Show();
            Hide();
        }

        private void cadastrarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Fornecedor.frmCadastrarFornecedor tela = new Fornecedor.frmCadastrarFornecedor();
            tela.Show();
            Hide();
        }

        private void ImgBack_Click(object sender, EventArgs e)
        {
        }
        
       
        private void todosToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Telas.Fornecedor.frmConsultarTodosFornecedores tela = new Fornecedor.frmConsultarTodosFornecedores();
            tela.Show();
            Hide();
        }

        private void iDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.Fornecedor.frmConsultarPorID tela = new Fornecedor.frmConsultarPorID();
            tela.Show();
            Hide();
        }

        private void nomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.Fornecedor.frmConsultarPorNome tela = new Fornecedor.frmConsultarPorNome();
            tela.Show();
            Hide();
        }

        private void alterarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Telas.Fornecedor.frmAlterarFornecedor tela = new Fornecedor.frmAlterarFornecedor();
            tela.Show();
            Hide();
        }

        private void removerToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Telas.Fornecedor.frmRemoverFornecedor tela = new Fornecedor.frmRemoverFornecedor();
            tela.Show();
            Hide();
        }

        private void frmMenuGerente_Load(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Estoque.frmCadastrarEstoque tela = new Estoque.frmCadastrarEstoque();
            tela.Show();
            Hide();
        }

        private void todosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Estoque.frmConsultarPorTodos tela = new Estoque.frmConsultarPorTodos();
            tela.Show();
            Hide();
        }

        private void porIDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Estoque.frmConsultarPorId tela = new Estoque.frmConsultarPorId();
            tela.Show();
            Hide();
        }

        private void alterarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Estoque.frmAlterarEstoque tela = new Estoque.frmAlterarEstoque();
            tela.Show();
            Hide();
        }

        private void removerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Estoque.frmRemoverEstoque tela = new Estoque.frmRemoverEstoque();
            tela.Show();
            Hide();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RH.frmCadastrarFuncionario tela = new RH.frmCadastrarFuncionario();
            tela.Show();
            Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            HorarioEmSessao();
        }

        private void HorarioEmSessao()
        {
            TimeSpan sessao = DateTime.Now - Model.Entities.UsuarioLogado.horariologin;
            string horariosessao = sessao.ToString().Substring(0, 8);

            lblHorarioEmSessao.Text = horariosessao;
        }

        private void fluxoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Financeiro.frmFluxoDeCaixa tela = new Financeiro.frmFluxoDeCaixa();
            tela.Show();
            Hide();
        }

        private void porQuantidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque.frmConsultarPorQuantidade tela = new Estoque.frmConsultarPorQuantidade();
            tela.Show();
            Hide();
        }

        private void folhaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolhaPagamento.frmpagamento tela = new FolhaPagamento.frmpagamento();
            tela.Show();
            Hide();
        }

        private void aPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void despesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Financeiro.frmFluxoDeCaixa tela = new Financeiro.frmFluxoDeCaixa();
            tela.Show();
            Hide();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Estoque.frmSaidaDeEstoque tela = new Estoque.frmSaidaDeEstoque();
            tela.Show();
            Hide();
        }

        private void imgFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgVoltar_Click(object sender, EventArgs e)
        {
            Login.Gerente.frmLogin tela = new Login.Gerente.frmLogin();
            tela.Show();
            Hide();
        }

        private void alterarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            RH.frmAlterarFuncionario tela = new RH.frmAlterarFuncionario();
            tela.Show();
            Hide();
        }

        private void removerToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            RH.frmRemoverFuncionario tela = new RH.frmRemoverFuncionario();
            tela.Show();
            Hide();
        }

        private void todosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            RH.frmConsultarFuncionario tela = new RH.frmConsultarFuncionario();
            tela.Show();
            Hide();
        }

        private void porIDToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            RH.frmConsultarPorID tela = new RH.frmConsultarPorID();
            tela.Show();
            Hide();
        }

        private void mandarSMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRM.frmPromocao tela = new CRM.frmPromocao();
            tela.Show();
            Hide();
        }

        private void gerarCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartao_Ponto.frmGerarCodBarra tela = new Cartao_Ponto.frmGerarCodBarra();
            tela.Show();
            Hide();
        }

        private void baterPontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartao_Ponto.frmBaterPonto tela = new Cartao_Ponto.frmBaterPonto();
            tela.Show();
            Hide();
        }

        private void imgFechar_MouseEnter(object sender, EventArgs e)
        {
            imgFechar.BackColor = Color.Red;
            imgFechar.ForeColor = Color.White;
        }

        private void imgFechar_MouseLeave(object sender, EventArgs e)
        {
            imgFechar.BackColor = Color.FromArgb(196, 231, 167);
            imgFechar.ForeColor = Color.Black;
        }

        private void imgVoltar_MouseEnter(object sender, EventArgs e)
        {
            imgVoltar.BackColor = Color.White;
        }

        private void imgVoltar_MouseLeave(object sender, EventArgs e)
        {
            imgVoltar.BackColor = Color.FromArgb(196, 231, 167);
        }

        private void lblPerfil_Click(object sender, EventArgs e)
        {
            Login.Gerente.frmPerfil tela = new Login.Gerente.frmPerfil();
            tela.Show();
            Hide();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Financeiro.frmCadastrarConta tela = new Financeiro.frmCadastrarConta();
            tela.Show();
            Hide();
        }

        private void aReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Financeiro.frmContaAReceber tela = new Financeiro.frmContaAReceber();
            tela.Show();
            Hide();
        }

        private void alterarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Financeiro.frmAlterarContaPagar tela = new Financeiro.frmAlterarContaPagar();
            tela.Show();
            Hide();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Financeiro.frmDeletarContasPagar tela = new Financeiro.frmDeletarContasPagar();
            tela.Show();
            Hide();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Financeiro.frmConsultarTodosContaPagar tela = new Financeiro.frmConsultarTodosContaPagar();
            tela.Show();
            Hide();
        }

        private void alterarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Financeiro.frmAlterarContasReceber tela = new Financeiro.frmAlterarContasReceber();
            tela.Show();
            Hide();
        }

        private void deletarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Financeiro.frmDeletarContasReceber tela = new Financeiro.frmDeletarContasReceber();
            tela.Show();
            Hide();
        }

        private void consultarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Financeiro.frmConsultarTodosContasReceber tela = new Financeiro.frmConsultarTodosContasReceber();
            tela.Show();
            Hide();
        }

        private void validarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prestador.frmValidarPrestador tela = new Prestador.frmValidarPrestador();
            tela.Show();
            Hide();
        }
    }
}
