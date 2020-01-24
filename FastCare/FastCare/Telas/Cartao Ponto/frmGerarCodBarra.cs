using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastCare.Telas.Cartao_Ponto
{
    public partial class frmGerarCodBarra : Form
    {
        public frmGerarCodBarra()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text;

                if (id == string.Empty || id == "0")
                    throw new ArgumentException("ID Inválido");

                APIs.ApiBarCode BarCode = new APIs.ApiBarCode();
                Image code = BarCode.SalvarCodigoBarras(id);

                imgCode.Image = code;
                lblNome.Visible = true;
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmGerarCodBarra tela = new frmGerarCodBarra();
            Utils.ImprimirTela Impressoes = new Utils.ImprimirTela();
            Impressoes.Imprimir(tela, panelPrint);
        }

        private void ImgBack_Click(object sender, EventArgs e)
        {
            Outros.frmMenuGerente tela = new Outros.frmMenuGerente();
            tela.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmGerarCodBarra_Load(object sender, EventArgs e)
        {

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
            ImgBack.ForeColor = Color.FromArgb(196, 231, 167);
        }
    }
}
