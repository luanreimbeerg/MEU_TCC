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
    public partial class frmCadastrarPrestador : Form
    {
        public frmCadastrarPrestador()
        {
            InitializeComponent();
        }

        private void frmCadastrarPrestador_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ImgBack_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model.Entities.tb_prestador pres = new Model.Entities.tb_prestador();
            Business.PrestadorBusiness buspre = new Business.PrestadorBusiness();
            pres.ds_cel = txtCel.Text;
            pres.ds_cep = txtCep.Text;
            pres.ds_cpf = txtCpf.Text;
            pres.ds_email = txtEmail.Text;  
            pres.ds_rg = txtRg.Text;
            pres.ds_tel = txtTel.Text;
            pres.dt_nasc = dtpNasc.Value;
            pres.end_prestador = txtEnd.Text;
            pres.uf_estado = cboUf.Text;
            pres.nm_cargo = cboSetor.Text;
            pres.nm_prestador = txtNome.Text;
            pres.nu_prestador = txtNu.Text;
            pres.bt_ativo = false;
            if (rdnF.Checked == true)
                pres.ds_genero = "F";
            else
                pres.ds_genero = "M";

            buspre.Inserir(pres);
            MessageBox.Show("Pedido enviado com sucesso, enviaremos um email informando se sua conta foi aceita", "Fast Care", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        private void txtCep_TextChanged(object sender, EventArgs e)
        {

            if (txtCep.Text.Length == 9)
            {
                string cep = txtCep.Text;
                APIs.ApiCep cepp = new APIs.ApiCep();
                txtEnd.Text = cepp.Buscar(cep);
            }
            else
            {
                txtEnd.Text = string.Empty;
            }
        }
    }
}
