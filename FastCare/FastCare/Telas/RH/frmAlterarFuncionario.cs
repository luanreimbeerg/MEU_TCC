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
    public partial class frmAlterarFuncionario : Form
    {
        public frmAlterarFuncionario()
        {
            InitializeComponent();

            Business.RHBusiness busrh = new Business.RHBusiness();
            List<Model.Entities.tb_funcionario> list = busrh.ListarPorTodos();

            cboCpf.DisplayMember = nameof(Model.Entities.tb_funcionario.ds_cpf);
            cboCpf.DataSource = list;
        }

        private void cboCpf_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.Entities.tb_funcionario func = cboCpf.SelectedItem as Model.Entities.tb_funcionario;

            txtCargo.Text = func.nm_cargo;
            txtCel.Text = func.ds_cel;
            txtCep.Text = func.ds_cep;
            txtCpf.Text = func.ds_cpf;
            txtEmail.Text = func.ds_email;
            txtEnd.Text = func.end_funcionario;
            txtNCasa.Text = func.nu_funcionario;
            txtNome.Text = func.nm_funcionario;
            txtRg.Text = func.ds_rg;
            txtTel.Text = func.ds_tel;
            nudSalario.Value = func.qt_salario;
            nudVa.Value = Convert.ToDecimal(func.vl_va);
            nudVt.Value = Convert.ToDecimal(func.vl_vt);
            cboSetor.Text = func.ds_setor;
            cboUF.Text = func.uf_estado;
            dtpContratacao.Value = func.dt_contratacao;
            dtpNasc.Value = func.dt_nasc;

            if (func.ds_genero == "M")
                rdnM.Checked = true;
            else
                rdnF.Checked = true;

            if (func.est_civil == "Casado")
                rdnCasado.Checked = true;
            else
                rdnSolteiro.Checked = true;

            if (func.bl_va == true)
                chkVa.Checked = true;

            if (func.bl_vt == true)
                chkVt.Checked = true;
        }

        private void chkVt_CheckedChanged(object sender, EventArgs e)
        {
            AcoesBeneficios();
        }

        private void chkVa_CheckedChanged(object sender, EventArgs e)
        {
            AcoesBeneficios();
        }

        private void AcoesBeneficios()
        {
            if (chkVa.Checked == true || chkVt.Checked == true)
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

        private void imgCadastrar_Click(object sender, EventArgs e)
        {
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Outros.frmMenuGerente tela = new Outros.frmMenuGerente();
            tela.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Entities.tb_funcionario func = cboCpf.SelectedItem as Model.Entities.tb_funcionario;
                Model.Entities.tb_funcionario novo = new Model.Entities.tb_funcionario();

                novo.id_funcionario = func.id_funcionario;
                novo.bl_va = chkVa.Checked;
                novo.bl_vt = chkVt.Checked;
                novo.ds_cel = txtCel.Text;
                novo.ds_cep = txtCep.Text;
                novo.ds_cpf = txtCpf.Text;
                novo.ds_email = txtEmail.Text.Trim();
                novo.ds_rg = txtRg.Text;
                novo.ds_setor = cboSetor.Text;
                novo.ds_tel = txtTel.Text;
                novo.dt_contratacao = dtpContratacao.Value;
                novo.dt_nasc = dtpNasc.Value;
                novo.end_funcionario = txtEnd.Text;
                novo.nm_cargo = txtCargo.Text.Trim();
                novo.nm_funcionario = txtNome.Text.Trim();
                novo.qt_salario = nudSalario.Value;
                novo.nu_funcionario = txtNCasa.Text.Trim();
                novo.uf_estado = cboUF.Text;
                novo.vl_va = nudVa.Value;
                novo.vl_vt = nudVt.Value;

                if (rdnCasado.Checked == true)
                    novo.est_civil = "Casado";
                else
                    novo.est_civil = "Solteiro";

                if (rdnM.Checked == true)
                    novo.ds_genero = "M";
                else
                    novo.ds_genero = "F";

                Business.RHBusiness busrh = new Business.RHBusiness();
                busrh.Alterar(novo);

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

        private void cboCpf_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Model.Entities.tb_funcionario func = cboCpf.SelectedItem as Model.Entities.tb_funcionario;

            txtCargo.Text = func.nm_cargo;
            txtCel.Text = func.ds_cel;
            txtCep.Text = func.ds_cep;
            txtCpf.Text = func.ds_cpf;
            txtEmail.Text = func.ds_email;
            txtEnd.Text = func.end_funcionario;
            txtNCasa.Text = func.nu_funcionario;
            txtNome.Text = func.nm_funcionario;
            txtRg.Text = func.ds_rg;
            txtTel.Text = func.ds_tel;
            nudSalario.Value = Convert.ToDecimal(func.qt_salario);
            nudVa.Value = Convert.ToDecimal(func.vl_va);
            nudVt.Value = Convert.ToDecimal(func.vl_vt);
            cboSetor.Text = func.ds_setor;
            cboUF.Text = func.uf_estado;
            dtpContratacao.Value = func.dt_contratacao;
            dtpNasc.Value = func.dt_nasc;

            if (func.ds_genero == "M")
                rdnM.Checked = true;
            else
                rdnF.Checked = true;

            if (func.est_civil == "Casado")
                rdnCasado.Checked = true;
            else
                rdnSolteiro.Checked = true;

            if (func.bl_va == true)
                chkVa.Checked = true;

            if (func.bl_vt == true)
                chkVt.Checked = true;
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

        private void chkVt_CheckedChanged_1(object sender, EventArgs e)
        {
            AcoesBeneficios();
            VT();
        }

        private void chkVa_CheckedChanged_1(object sender, EventArgs e)
        {
            AcoesBeneficios();
        }

        private void VT()
        {
            decimal salario = nudSalario.Value;
            nudVt.Value = salario * 0.06m;
        }

        private void nudSalario_ValueChanged(object sender, EventArgs e)
        {
            VT();
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

        private void cboCpf_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            Model.Entities.tb_funcionario func = cboCpf.SelectedItem as Model.Entities.tb_funcionario;

            txtCargo.Text = func.nm_cargo;
            txtCel.Text = func.ds_cel;
            txtCep.Text = func.ds_cep;
            txtCpf.Text = func.ds_cpf;
            txtEmail.Text = func.ds_email;
            txtEnd.Text = func.end_funcionario;
            txtNCasa.Text = func.nu_funcionario;
            txtNome.Text = func.nm_funcionario;
            txtRg.Text = func.ds_rg;
            txtTel.Text = func.ds_tel;
            nudSalario.Value = Convert.ToDecimal(func.qt_salario);
            nudVa.Value = Convert.ToDecimal(func.vl_va);
            nudVt.Value = Convert.ToDecimal(func.vl_vt);
            cboSetor.Text = func.ds_setor;
            cboUF.Text = func.uf_estado;
            dtpContratacao.Value = func.dt_contratacao;
            dtpNasc.Value = func.dt_nasc;

            if (func.ds_genero == "M")
                rdnM.Checked = true;
            else
                rdnF.Checked = true;

            if (func.est_civil == "Casado")
                rdnCasado.Checked = true;
            else
                rdnSolteiro.Checked = true;

            if (func.bl_va == true)
                chkVa.Checked = true;

            if (func.bl_vt == true)
                chkVt.Checked = true;
        }
    }
}
