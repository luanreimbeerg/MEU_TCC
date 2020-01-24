using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastCare.Telas.RH
{
    public partial class frmCadastrarFuncionario : Form
    {
        public frmCadastrarFuncionario()
        {
            InitializeComponent();
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

        private void AcoesBeneficios()
        {
            if (chkVa.Checked == true ||chkVt.Checked == true)
                lblvalores.Visible = true;
            else
                lblvalores.Visible = false;

            if (chkVa.Checked == true)
            {
                lblva.Visible = true;
                nudVa.Visible = true;
            }
            else
            {
                lblva.Visible = false;
                nudVa.Visible = false;
                nudVa.Value = 0;
            }

            if (chkVt.Checked == true)
            {
                lblvt.Visible = true;
                nudVt.Visible = true;
            }
            else
            {
                lblvt.Visible = false;
                nudVt.Visible = false;
                nudVt.Value = 0;
            }
        }

        private void chkVt_CheckedChanged(object sender, EventArgs e)
        {
            AcoesBeneficios();
            VT();
        }

        private void chkVa_CheckedChanged(object sender, EventArgs e)
        {
            AcoesBeneficios();
        }

        private void imgClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ImgBack_Click(object sender, EventArgs e)
        {
            Outros.frmMenuGerente tela = new Outros.frmMenuGerente();
            tela.Show();
            Hide();
        }

        private void nudSalario_ValueChanged(object sender, EventArgs e)
        {
            VT();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Outros.frmMenuGerente tela = new Outros.frmMenuGerente();
            tela.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Entities.tb_funcionario f = new Model.Entities.tb_funcionario();
                Business.RHBusiness rh = new Business.RHBusiness();

                f.bl_va = chkVa.Checked;
                f.bl_vt = chkVt.Checked;
                f.ds_cel = txtCel.Text;
                f.ds_cep = txtCep.Text;
                f.ds_cpf = txtCpf.Text;
                f.ds_email = txtEmail.Text.Trim();
                f.ds_rg = txtRg.Text;
                f.ds_setor = cboSetor.Text;
                f.ds_tel = txtTel.Text;
                f.dt_contratacao = dtpContratacao.Value;
                f.dt_nasc = dtpNasc.Value;
                f.end_funcionario = txtEnd.Text;
                f.nm_cargo = txtCargo.Text.Trim();
                f.nm_funcionario = txtNome.Text.Trim();
                f.qt_salario = nudSalario.Value;
                f.nu_funcionario = txtNCasa.Text.Trim();
                f.uf_estado = cboUF.Text;
                f.vl_va = nudVa.Value;
                f.vl_vt = nudVt.Value;

                if (rdnCasado.Checked == true)
                    f.est_civil = "Casado";
                else
                    f.est_civil = "Solteiro";

                if (rdnM.Checked == true)
                    f.ds_genero = "M";
                else
                    f.ds_genero = "F";

                Business.RHBusiness busrh = new Business.RHBusiness();
                busrh.Inserir(f);

                MessageBox.Show("Funcionário cadastrado com sucesso", "Fast Care", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void VT()
        {
            decimal salario = nudSalario.Value;
            nudVt.Value = salario * 0.06m;
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            Button1.BackColor = Color.Red;
            Button1.ForeColor = Color.White;
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            Button1.BackColor = Color.FromArgb(196, 231, 167);
            Button1.ForeColor = Color.White;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.LawnGreen;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(196, 231, 167);
        }
    }
}
