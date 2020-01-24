using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastCare.Telas.Login.Cliente
{
    public partial class frmCadastrarDados : Form
    {
        public frmCadastrarDados()
        {
            InitializeComponent();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightGreen;
            button2.ForeColor = Color.WhiteSmoke;
        }

        private void frmCadastrarDados_Load(object sender, EventArgs e)
        {
        }

        private void lblFechar_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.WhiteSmoke;
            button2.ForeColor = Color.Black;
        }

        private void lblMinimizar_MouseEnter(object sender, EventArgs e)
        {
            ImgBack.BackColor = Color.LightGreen;
            ImgBack.ForeColor = Color.WhiteSmoke;
        }

        private void ImgBack_MouseLeave(object sender, EventArgs e)
        {
            ImgBack.BackColor = Color.WhiteSmoke;
            ImgBack.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ImgBack_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model.Entities.tb_cliente cli = new Model.Entities.tb_cliente();
            Business.ClienteBusiness buscli = new Business.ClienteBusiness();
            cli.ds_cel = txtCel.Text;
            cli.ds_cep = txtCep.Text;
            cli.ds_cpf = txtCpf.Text;
            cli.ds_email = txtEmail.Text;
            cli.ds_rg = txtRg.Text;
            cli.ds_tel = txtTel.Text;
            cli.dt_nasc = dtpNasc.Value;
            cli.end_cliente = txtEnd.Text;
            cli.uf_estado = cboUf.Text;
            cli.nm_cliente = txtNome.Text;
            cli.nu_cliente = txtNu.Text;
            if (rdnF.Checked == true)
                cli.ds_genero = "F";
            else
                cli.ds_genero = "M";

            buscli.Inserir(cli);

            MessageBox.Show("Cadastro efetuado com sucesso", "Fast Care", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmCadastrar tela = new frmCadastrar();
            tela.Show();
            Hide();
        }

        private void txtNu_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
